using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Services
{
    public class MapService
    {
        private IDbContextFactory<FPVDbContext> _dbContextFactory;

        public MapService(IDbContextFactory<FPVDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<bool> AddMap(Map map)
        {
            if (map is null)
                throw new ArgumentNullException(nameof(map));

            await using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                context.Maps.Add(map);
                try
                {
                    await context.SaveChangesAsync();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return false;
                }
            }
        }

        public async Task<IList<Map>> GetMaps(User? user = null)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();

            if (user is null)
            {
                return await context.Maps
                    .Include(m => m.Courses)
                    .ToListAsync();
            }

            return await context.Maps
                .Where(m => m.Courses
                    .Any(c => c.CompletedRuns.Any(r => r.UserID == user.ID)))
                .Include(m => m.Courses) // include courses for checkbox display
                .ToListAsync();
        }
    }
}
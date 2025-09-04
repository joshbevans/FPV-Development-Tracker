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

        public async Task<IList<Map>> GetMaps()
        {
            using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                return await context.Maps
                    .Include(m => m.Courses)
                    .ToListAsync();
            }
        }
    }
}
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

        public async Task AddMap(Map map)
        {
            if (map is null)
                throw new ArgumentNullException(nameof(map));

            using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                context.Maps.Add(map);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IList<Map>> GetMaps()
        {
            using (FPVDbContext context = _dbContextFactory.CreateDbContext())
            {
                return await context.Maps.ToListAsync();
            }
        }
    }
}

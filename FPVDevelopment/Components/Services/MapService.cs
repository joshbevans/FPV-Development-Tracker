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

        public void AddMap(Map map)
        {
            if (map is null)
                throw new ArgumentNullException(nameof(map));

            using (FPVDbContext context = _dbContextFactory.CreateDbContext())
            {
                context.Maps.Add(map);
                context.SaveChanges();
            }
        }
    }
}

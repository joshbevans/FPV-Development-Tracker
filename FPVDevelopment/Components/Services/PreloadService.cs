using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Services
{
    public class PreloadService
    {
        private IDbContextFactory<FPVDbContext> _dbContextFactory;

        public PreloadService(IDbContextFactory<FPVDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task PreloadDataAsync(User user)
        {
            using (FPVDbContext context = _dbContextFactory.CreateDbContext())
            {
                await context.Drones
                    .Where(x => x.User == null || x.User == user)
                    .LoadAsync();

                await context.Maps.LoadAsync();

                await context.CompletedRuns
                    .Where(x => x.User == user)
                    .LoadAsync();
            }
        }
    }
}

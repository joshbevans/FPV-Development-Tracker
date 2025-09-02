using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Services
{
    public class DroneService
    {
        private IDbContextFactory<FPVDbContext> _dbContextFactory;

        public DroneService(IDbContextFactory<FPVDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task AddDrone(Drone drone)
        {
            if (drone is null)
                throw new ArgumentNullException(nameof(drone));

            using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                context.Drones.Add(drone);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IList<Drone>> GetDrones(User user)
        {
            using (FPVDbContext context = _dbContextFactory.CreateDbContext())
            {
                return await context.Drones
                    .Where(x => x.User == null || x.User == user)
                    .ToListAsync();
            }
        }
    }
}

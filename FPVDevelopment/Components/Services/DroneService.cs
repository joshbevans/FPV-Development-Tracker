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

        public async Task<bool> AddDrone(Drone drone)
        {
            if (drone is null)
                throw new ArgumentNullException(nameof(drone));

            await using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                context.Drones.Add(drone);
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

        public async Task<IList<Drone>> GetDrones(User? user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));
            
            using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                return await context.Drones
                    .Include(d => d.User)
                    .Where(d => d.User == null || d.User.ID == user.ID)
                    .ToListAsync();
            }
        }
    }
}

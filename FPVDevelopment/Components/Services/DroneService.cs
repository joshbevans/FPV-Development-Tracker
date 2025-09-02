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

        public void AddDrone(Drone drone)
        {
            if (drone is null)
                throw new ArgumentNullException(nameof(drone));

            using (FPVDbContext context = _dbContextFactory.CreateDbContext())
            {
                context.Drones.Add(drone);
                context.SaveChanges();
            }
        }
    }
}

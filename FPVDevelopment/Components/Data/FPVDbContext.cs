using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FPVDevelopment.Components.Data
{
    public class FPVDbContext : DbContext
    {
        public FPVDbContext(DbContextOptions<FPVDbContext> options) 
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Drone> Drones { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<CompletedRun> CompletedRuns { get; set; }
    }
}

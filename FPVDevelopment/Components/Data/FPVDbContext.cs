using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Data
{
    public class FPVDbContext : DbContext
    {
        public FPVDbContext(DbContextOptions<FPVDbContext> options) 
            : base(options)
        {
        }

        public DbSet<CompletedRun> CompletedRuns { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Drone> Drones { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sim> Sims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Map>()
                .HasOne(m => m.Sim)
                .WithMany(s => s.Maps)
                .HasForeignKey(m => m.SimID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Map>()
                .HasOne(m => m.User)
                .WithMany(u => u.Maps)
                .HasForeignKey(m => m.UserID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Map)
                .WithMany(m => m.Courses)
                .HasForeignKey(c => c.MapID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.User)
                .WithMany(u => u.Courses)
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<CompletedRun>()
                .HasOne(cr => cr.User)
                .WithMany(u => u.CompletedRuns)
                .HasForeignKey(cr => cr.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CompletedRun>()
                .HasOne(cr => cr.Course)
                .WithMany(c => c.CompletedRuns)
                .HasForeignKey(cr => cr.CourseID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Services
{
    public class CompletedRunService
    {
        private IDbContextFactory<FPVDbContext> _dbContextFactory;

        public CompletedRunService(IDbContextFactory<FPVDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<bool> AddCompletedRun(CompletedRun completedRun, User user)
        {
            if (completedRun is null)
                throw new ArgumentNullException(nameof(completedRun));
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                completedRun.Map = context.Maps
                    .First(map => map.ID == completedRun.MapID);
                completedRun.UserID = user.ID;
                completedRun.Date = DateTime.Now;
                context.CompletedRuns.Add(completedRun);
                
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

        public async Task<IList<CompletedRun>> GetCompletedRuns(User? user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));
            
            using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                return await context.CompletedRuns
                    .Where(r => r.UserID == user.ID)
                    .Include(r => r.Map)
                    .Include(r => r.Drone)
                    .ToListAsync();
            }
        }
    }
}

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

        public async Task AddCompletedRun(CompletedRun completedRun, User currentUser)
        {
            if (completedRun is null)
                throw new ArgumentNullException(nameof(completedRun));

            using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
            {
                completedRun.Map = context.Maps
                    .First(map => map.ID == completedRun.MapID);
                completedRun.UserID = currentUser.ID;
                completedRun.Date = DateTime.Now;
                context.CompletedRuns.Add(completedRun);
                await context.SaveChangesAsync();
            }
        }

        public async Task GetCompletedRuns(User user)
        {

        }
    }
}

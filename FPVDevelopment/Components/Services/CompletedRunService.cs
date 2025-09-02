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

        public void AddCompletedRun(CompletedRun completedRun, User currentUser)
        {
            if (completedRun is null)
                throw new ArgumentNullException(nameof(completedRun));

            using (FPVDbContext context = _dbContextFactory.CreateDbContext())
            {
                completedRun.Map = context.Maps
                    .First(map => map.ID == completedRun.MapID);
                completedRun.UserID = currentUser.ID;
                completedRun.Date = DateTime.Now;
                context.CompletedRuns.Add(completedRun);
                context.SaveChanges();
            }
        }

        public void GetCompletedRuns(User user)
        {

        }
    }
}

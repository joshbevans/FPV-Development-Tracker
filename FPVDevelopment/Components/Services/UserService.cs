using FPVDevelopment.Components.Data;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Services
{
    public class UserService
    {
        private IDbContextFactory<FPVDbContext> _dbContextFactory;

        public UserService(IDbContextFactory<FPVDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        // CURRENTLY OUT OF SCOPE OF THIS DEVELOPMENT CYCLE
    }
}

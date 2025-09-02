using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Models;
using FPVDevelopment.Components.Pages;
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

        public async Task<User> Login(string username, string password)
        {
            using (FPVDbContext context = _dbContextFactory.CreateDbContext())
            {
                await context.Users.LoadAsync();

                if (!context.Users.Any())
                    throw new ArgumentNullException(nameof(User));

                return context.Users.FirstOrDefault();
            }
        }
    }
}



// CURRENTLY OUT OF SCOPE FOR THIS DEVELOPMENT CYCLE
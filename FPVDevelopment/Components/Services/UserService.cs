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
                
                if (username == "melon")
                    return context.Users.FirstOrDefault(u => u.Username == "melon");
                if (username == "melonBasic")
                    return context.Users.FirstOrDefault(u => u.Username == "melonBasic");
                
                return null;
            }
        }
    }
}



// CURRENTLY OUT OF SCOPE FOR THIS DEVELOPMENT CYCLE
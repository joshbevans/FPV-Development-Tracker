using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Data
{
    public class FPVDbContext : DbContext
    {
        public FPVDbContext(DbContextOptions<FPVDbContext> options) 
            : base(options)
        {

        }
    }
}

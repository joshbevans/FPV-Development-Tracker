using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Services;

public class SimService
{
    private IDbContextFactory<FPVDbContext> _dbContextFactory;

    public SimService(IDbContextFactory<FPVDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }
    
    public async Task<IList<Sim>> GetSims()
    {
        using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Sims
            .Include(s => s.Maps)
            .Include(s => s.Drones)
            .ToListAsync();
    }
}
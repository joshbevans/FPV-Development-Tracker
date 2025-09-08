using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FPVDevelopment.Components.Services;

public class CourseService
{
    private IDbContextFactory<FPVDbContext> _dbContextFactory;

    public CourseService(IDbContextFactory<FPVDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<bool> AddCourse(Course course)
    {
        if (course is null)
            throw new ArgumentNullException(nameof(course));

        await using (FPVDbContext context = await _dbContextFactory.CreateDbContextAsync())
        {
            context.Courses.Add(course);
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

    public async Task<IList<Course>> GetCourses(User? user = null)
    {
        using var context = await _dbContextFactory.CreateDbContextAsync();

        if (user is null)
        {
            return await context.Courses
                .Include(c => c.Map) // optional if you need map info
                .ToListAsync();
        }

        return await context.Courses
            .Where(c => c.CompletedRuns.Any(r => r.UserID == user.ID))
            .Include(c => c.Map)
            .ToListAsync();
    }

}
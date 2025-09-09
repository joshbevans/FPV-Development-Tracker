using System.ComponentModel.DataAnnotations;
using FPVDevelopment.Components.Globals;

namespace FPVDevelopment.Components.Data.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        [StringLength(20)]
        public string DisplayName { get; set; }

        public Enums.UserLevel UserLevel { get; set; } = 0;

        public ICollection<CompletedRun> CompletedRuns { get; set; } = new List<CompletedRun>();
        public ICollection<Map> Maps { get; set; } = new List<Map>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}

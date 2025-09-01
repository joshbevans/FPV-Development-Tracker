using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(20)]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        [StringLength(20)]
        public string DisplayName { get; set; }

        public ICollection<CompletedRun> CompletedRuns { get; set; } = new List<CompletedRun>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models
{
    public class CompletedRun
    {
        [Key]
        public int ID { get; set; }
        public TimeSpan? Time { get; set; }
        public DateTime Date { get; set; }
        public int? CrashCount { get; set; } = 0;

        public User User { get; set; }
        public Map Map { get; set; }
        public Drone Drone { get; set; }
    }
}

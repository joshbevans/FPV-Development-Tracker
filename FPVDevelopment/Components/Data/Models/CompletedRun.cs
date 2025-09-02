using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models
{
    public class CompletedRun
    {
        [Key]
        public int CompletedRunID { get; set; }
        public TimeSpan CompletedRunTime { get; set; }
        public DateTime CompletedRunDate { get; set; }
        public int CrashCount { get; set; }

        public User User { get; set; }
        public Map Map { get; set; }
        public Drone Drone { get; set; }
    }
}

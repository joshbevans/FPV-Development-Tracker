using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPVDevelopment.Components.Data.Models
{
    public class CompletedRun
    {
        [Key]
        public int ID { get; set; }
        public TimeSpan? Time { get; set; }
        public DateTime Date { get; set; }
        public int? CrashCount { get; set; } = 0;
        public int UserID { get; set; }
        public int MapID { get; set; }
        public int DroneID { get; set; }

        public User User { get; set; }
        public Map Map { get; set; }
        public Drone Drone { get; set; }
    }
}

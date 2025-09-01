using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models
{
    public class Drone
    {
        [Key]
        public int DroneID { get; set; }
        [StringLength(20)]
        public string DroneName { get; set; }
        public DroneSize DroneSize { get; set; }

        public ICollection<CompletedRun> CompletedRuns {  get; set; } = new List<CompletedRun>();
    }
}

using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models
{
    public class Drone
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public DroneSize Size { get; set; }

        public ICollection<CompletedRun> CompletedRuns {  get; set; } = new List<CompletedRun>();
    }
}

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
        public int? UsedID { get; set; }
        public User? User { get; set; } = null;
        public DroneSize Size { get; set; } = DroneSize.SevenInch;

        public ICollection<CompletedRun> CompletedRuns {  get; set; } = new List<CompletedRun>();
    }
}

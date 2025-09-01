using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models
{
    public class Drone
    {
        [Key]
        public int DroneID { get; set; }

        public string DroneName { get; set; }

        public DroneSize DroneSize { get; set; }
    }
}

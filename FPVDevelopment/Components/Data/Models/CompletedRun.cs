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
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int DroneID { get; set; }

        public User User { get; set; }
        public Course Course { get; set; }
        public Drone Drone { get; set; }
    }
}

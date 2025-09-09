using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models
{
    public class Map
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? UserID { get; set; }
        public int SimID { get; set; }
        
        public User? User { get; set; }
        public Sim  Sim { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}

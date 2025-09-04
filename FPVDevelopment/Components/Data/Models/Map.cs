using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models
{
    public class Map
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}

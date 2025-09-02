using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models
{
    public class Map
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public MapDifficulty Difficulty { get; set; } = MapDifficulty.Easy;

        public ICollection<CompletedRun> CompletedRuns { get; set; } = new List<CompletedRun>();
    }
}

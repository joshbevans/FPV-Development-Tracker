using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models
{
    public class Map
    {
        [Key]
        public int MapID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public MapDifficulty Difficulty { get; set; } = MapDifficulty.Basic;

        public ICollection<CompletedRun> CompletedRuns { get; set; } = new List<CompletedRun>();
    }
}

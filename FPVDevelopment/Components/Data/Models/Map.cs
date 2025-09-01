using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models
{
    public class Map
    {
        [Key]
        public int MapID { get; set; }
        [StringLength(50)]
        public string MapName { get; set; }
        public MapDifficulty MapDifficulty { get; set; }

        public ICollection<CompletedRun> CompletedRuns { get; set; } = new List<CompletedRun>();
    }
}

using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models
{
    public class Map
    {
        [Key]
        public int MapID { get; set; }

        public string MapName { get; set; }

        public MapDifficulty MapDifficulty { get; set; }
    }
}

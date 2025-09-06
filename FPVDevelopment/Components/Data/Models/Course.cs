using System.ComponentModel.DataAnnotations;
using static FPVDevelopment.Components.Globals.Enums;

namespace FPVDevelopment.Components.Data.Models;

public class Course
{
    [Key]
    public int ID { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    public Difficulty Difficulty { get; set; } = Difficulty.Easy;
    public int MapID { get; set; }
    
    public Map Map { get; set; }
    public ICollection<CompletedRun> CompletedRuns { get; set; } = new List<CompletedRun>();
}
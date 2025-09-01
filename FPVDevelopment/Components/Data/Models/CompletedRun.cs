using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models
{
    public class CompletedRun
    {
        [Key]
        public int CompletedRunID { get; set; }

        public TimeSpan CompletedRunTime { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models;

public class Sim
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    
    public ICollection<Drone> Drones { get; set; } = new List<Drone>();
    public ICollection<Map> Maps { get; set; } = new List<Map>();
}
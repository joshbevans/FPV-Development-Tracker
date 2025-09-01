using System.ComponentModel.DataAnnotations;

namespace FPVDevelopment.Components.Data.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string DisplayName { get; set; }
    }
}

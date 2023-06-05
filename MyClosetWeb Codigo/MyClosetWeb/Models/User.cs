using System.ComponentModel.DataAnnotations;

namespace MyClosetWeb.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}

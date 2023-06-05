using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyClosetWeb.Models
{
    public class Closet
    {
        [Key]
        public int ClosetId { get; set; }
        public List<Clothes> Clothes { get; set; }
       
        public Closet()
        {
            Clothes = new List<Clothes>();
        }

        // Relacionamento com o User
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyClosetWeb.Models
{
    public class Clothes
    {
        [Key]
        public int ClothId { get; set; }
        public string Nickname { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public TissueType Tissue { get; set; }
        public ClotheType Type { get; set; }
        public string Image { get; set; }
        
        [NotMapped] 
        public IFormFile ImageFile { get; set; }
    }
}

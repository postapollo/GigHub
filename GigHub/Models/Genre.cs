using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre //genre? no more than 255
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
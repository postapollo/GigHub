using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        //who is performing, when, where, what genre.

        public int Id { get; set; }


        public ApplicationUser Artist { get; set; }

        [Required] //to make sure this is not nullable. Each Required affacts the immediate object below, in vertical. 
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }
        //name of menu

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

       
        public Genre Genre { get; set;  }

        [Required]
        public byte GenreId { get; set; }
        
    }
    
}
using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate] //at runtime, the value in FutureDate is the value in Date Property 
        public string Date { get; set; } //string, because everything put in by the client is a string. 

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public  byte Genre { get; set; } //drop down list, numeric number for each item

        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTIme()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgdeBookingSystemV2.Models
{
    public class Location
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Stedsnavn er påkrevd")]
        [StringLength(50, ErrorMessage = "Stedsnavnet må bestå av 3 til 50tegn", MinimumLength = 3)]
        [Display(Name = "Lokasjon")]
        public string Name { get; set; }

    }
}
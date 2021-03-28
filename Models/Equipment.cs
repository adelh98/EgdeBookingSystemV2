using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgdeBookingSystemV2.Models
{
    public class Equipment
    {
        public int ID { get; set; }

        [Required] //Må fylles, med min og maks tegn.
        [Display(Name = "Navn")]
      //  [StringLength(50, ErrorMessage = "Navnet er for langt, maksimalt antall karakterer er 50.", MinimumLength = 3, ErrorMessage = "Navnet er for kort. Minst 3 karakterer. ")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Info { get; set; }

        [Required] //Oprettet objekter fra andre klasser for å få tilgang til å hente data(felter) fra de.
        [Display(Name = "Kategori")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Lokasjon")]
        public int LocationID { get; set; }
        public Location Location { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        
    }
}

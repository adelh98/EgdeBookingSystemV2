using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgdeBookingSystemV2.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Dette feltet er påkrevd")]
        [Display(Name = "Navn")]
       // [StringLength(50, ErrorMessage = "Navnet er for langt, maksimalt antall karakterer er 50.", MinimumLength = 3, ErrorMessage = "Navnet er for kort. Minst 3 karakterer.")]
        public string Name { get; set; }

    }

}
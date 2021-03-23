using EgdeBookingSystemV2.Models;
using EgdeBookingSystemV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace EgdeBookingSystemV2.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            if (context.Equipments.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category { Name = "Tv") },
                new Category { Name = "Mobil") },
                new Category { Name = "PC")},
                new Category { Name = "Sensorer")},
                new Category { Name = "Diverse") }

            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            var locations = new Location[]
            {
                new Location { Name = "KRS") },
                new Location { Name = "GRM") }
            };

            context.Locations.AddRange(locations);
            context.SaveChanges();

//            var equipments = new Booking[]
//            {
//                new Equipment { Name = "Terminator", info = "Astala vista BABY", StartDate = DateTime.parse("2021-09-01"), Endate = DateTime.parse("2021-09-01"), EquipmentID = 1
//            };

//            context.Equipments.AddRange(equipments);
//            context.SaveChanges();

//var bookings = new Booking[]
//            {
//                new Booking { UserEmail = "test@email.com", StartDate = DateTime.parse("2021-09-01"), Endate = DateTime.parse("2021-09-01"), EquipmentID = 1 }
//            };

//            context.Bookings.AddRange(bookings);
//            context.SaveChanges();

        }
    }
}

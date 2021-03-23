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
        public static void Initialize(EgdeBookingSystemConnection context)
        {
            //context.Database.EnsureCreated();

            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category { Name = "Tv" },
                new Category { Name = "Mobil" },
                new Category { Name = "PC" },
                new Category { Name = "Sensorer" },
                new Category { Name = "Diverse" }

            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            var locations = new Location[]
            {
                new Location { Name = "KRS" },
                new Location { Name = "GRM" }
            };

            context.Locations.AddRange(locations);
            context.SaveChanges();

            var equipments = new Equipment[]
            {
                new Equipment { 
                    Name = "Iphone X", 
                    Info = "Hasta la vista BABY",
                    CategoryID = categories.Single( i => i.ID == 1).ID,
                    LocationID = locations.Single( i => i.ID == 2).ID
                },

                new Equipment { 
                    Name = "Samsung S8", 
                    Info = "Hasta la mista BABY",
                    CategoryID = categories.Single( s => s.Name == "Mobil").ID,
                    LocationID = locations.Single( s => s.Name == "KRS").ID
                },
                new Equipment { 
                    Name = "LG 40", 
                    Info = "Mellomstor TV",
                    CategoryID = categories.Single( s => s.Name == "Tv").ID,
                    LocationID = locations.Single( s => s.Name == "GRM").ID
                },

                new Equipment { 
                    Name = "Samsung 70", 
                    Info = "Stor TV",
                    CategoryID = categories.Single( s => s.Name == "Tv").ID,
                    LocationID = locations.Single( s => s.Name == "KRS").ID
                }

            };
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

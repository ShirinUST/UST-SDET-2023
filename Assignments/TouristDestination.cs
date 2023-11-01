using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? location, double rating, double pricePerNight)
        {
            Name = name;
            Location= location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Location { get; set; }
        public double Rating { get; set; }
        public double PricePerNight {  get; set; }

        public static List<TouristDestination> tour = new List<TouristDestination>();
        public static void SearchByRating(double rate)
        {
            var destination = tour.FindAll(x => x.Rating >= rate);
            if (destination != null)
            {
                foreach (var i in destination)
                {
                    Console.WriteLine(i.Name + " " + i.Location + " " + i.Rating+" "+i.PricePerNight);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No Places available");
            }
        }
        public static void SortByPrice()
        {
            var destination = tour.OrderBy(x => x.PricePerNight).ThenBy(x=>x.Rating);
                foreach (var i in destination)
                {
                    Console.WriteLine(i.Name + "  " + i.Location + "  " + i.Rating+"  "+i.PricePerNight);
                    Console.WriteLine();
                }
        }
        public static void FiltertByLocation(string location)
        {
            var destination = tour.FindAll(x => x.Location==location);
            if (destination != null)
            {
                foreach (var i in destination)
                {
                    Console.WriteLine(i.Name + "  " + i.Location + "  " + i.Rating + "  " + i.PricePerNight);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No Places available");
            }
        }

    }
}

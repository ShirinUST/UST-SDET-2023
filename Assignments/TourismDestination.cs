using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name {  get; set; }
        public string? Country { get; set; }
        public double Rating { get; set; }
        
        public static List<TourismDestination> tour=new List<TourismDestination>();
        public static void SortingRating()
        {
            var destination = tour.OrderByDescending(x => x.Rating).ThenBy(x=>x.Country);
            foreach(var i in destination)
            {
                Console.WriteLine(i.Name+" "+i.Country+" "+i.Rating);
                Console.WriteLine();
            }
        }
    }
}

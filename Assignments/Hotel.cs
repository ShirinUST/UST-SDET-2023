using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel:TourismDestination
    {
        public Hotel(string? name, string? country, double rating,string hotelName,int availableRooms) : base(name, country, rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
            HotelName = hotelName;
            AvailableRooms = availableRooms;
        }

        public string? HotelName {  get; set; }
        public int AvailableRooms {  get; set; }

        public async Task HotelBookingig(int hotelRoom, Hotel hotel)
        {

            if (hotelRoom <= AvailableRooms)
            {
                await Task.Delay(2000);
                AvailableRooms = AvailableRooms - hotelRoom;

                Console.WriteLine("Hotel booked for:{0} \t Rooms left:{1}", hotel.HotelName, AvailableRooms);
            }
            else
            {
                await Console.Out.WriteLineAsync("All rooms are booked");
            }
        }

    }
}

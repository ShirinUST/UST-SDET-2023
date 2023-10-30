using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelRoom
    {
        public int RoomNumber {  get; set; }
        public string? RoomType { get; set; }
        public bool IsBooked {  get; set; }
       

        public HotelRoom(int roomNumber, string? roomType, bool isBooked)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsBooked = isBooked;
        }
        public static HotelRoom GetRoom(int id)
        {
            return RoomReservation<HotelRoom>.hotel.Find(x => x.RoomNumber == id);
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        public static List<T> hotel = new List<T>();
        public void BookHotel(T item)
        {
            hotel.Add(item);
        }
        public void CancelHotel(T item)
        {
            hotel.Remove(item);
        }
        
    }
}

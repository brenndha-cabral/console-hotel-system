using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class Reserve
    {
        public int Id { get; set; }
        public int ReservedDays { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public List<Guest> Guests { get; set; }
        public Suite Suite { get; set; }

        public Reserve
        (
            int id,
            int reservedDays,
            string checkIn,
            string checkOut
        )
        {
            Id = id;
            ReservedDays = reservedDays;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

    
    }
}
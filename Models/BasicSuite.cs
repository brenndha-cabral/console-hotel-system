using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class BasicSuite : Suite
    {
        public bool HasBalcony { get; set; }

        public BasicSuite
        (
            int id,
            int capacity,
            decimal price,
            bool hasBalcony
        ) : base(id, "Basic", capacity, price, "Suite prática com o essencial")
        {
            HasBalcony = hasBalcony;
        }
    }
}
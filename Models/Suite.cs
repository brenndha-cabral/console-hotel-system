using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class Suite
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }

        public Suite
        (
            string id,
            string type,
            int capacity,
            decimal price,
            string details
        )
        {
            Id = id;
            Type = type;
            Capacity = capacity;
            Price = price;
            Details = details;
        }
    }
}
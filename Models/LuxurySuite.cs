using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class LuxurySuite : Suite
    {
    public bool HasJacuzzi { get; set; }
    public bool IncludesBreakfast { get; set; }

        public LuxurySuite
        (
            int id,
            int capacity,
            decimal price,
            bool hasJacuzzi,
            bool includesBreakfast
        ) : base(id, "Luxury", capacity, price, "Suíte de luxo com comodidades premium")
        {
            HasJacuzzi = hasJacuzzi;
            IncludesBreakfast = includesBreakfast;
        }
    }
}
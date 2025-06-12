using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class LuxurySuite : Suite
    {
    public decimal ValueJacuzziDay { get; set; }
    public decimal ValueBreakfastDay { get; set; }


        public LuxurySuite
        (
            string id,
            decimal valueJacuzziDay = 50M,
            decimal valueBreakfastDay = 30M
        ) : base(id, "Luxury", 5, 250M, "Suíte de luxo com comodidades premium")
        {
            ValueJacuzziDay = valueJacuzziDay;
            ValueBreakfastDay = valueBreakfastDay;
        }
    }
}
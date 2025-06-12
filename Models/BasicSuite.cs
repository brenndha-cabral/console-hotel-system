using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class BasicSuite : Suite
    {
         public BasicSuite
        (
            string id
        ) : base(id, "Basic", 3, 125M, "Suíte prática com o essencial")
        {
        }
    }
}
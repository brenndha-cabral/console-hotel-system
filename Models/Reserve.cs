using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class Reserve
    {
        public string Id { get; set; }
        public int ReservedDays { get; set; }
        public string CheckIn { get; set; }
        public List<Guest> Guests { get; set; }

        public Reserve
        (
            string id,
            int reservedDays,
            string checkIn
        )
        {
            Id = id;
            ReservedDays = reservedDays;
            CheckIn = checkIn;
            Guests = new List<Guest>();
        }

        public void RegisterReserve(List<Guest> guests, Suite suite)
        {
            if (guests.Count <= suite.Capacity)
            {
                Id = Guid.NewGuid().ToString();
                Guests = guests;
                CheckIn = DateTime.Now.ToString("dd/MM/yyyy - HH:mm");
            }
            else
            {
                throw new Exception($"A capacidade da suíte {suite.Type} é inferior a capacidade de hospedes informada. Capacidade: {suite.Capacity}");
            }
        }

        public List<Guest> GetAllGuests()
        {
            return Guests;
        }

        public Guest GetGuestById(string id)
        {
            Guest? guestFound = Guests.Find(i => i.Id == id);
            
            if (guestFound != null)
            {
                return guestFound;
            }
            else
            {
                throw new Exception($"{id} não corresponde a nenhum hóspede!");
            }
        }

        public int GetGuestsQuantity()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyValue(int reservedDays, Suite suite)
        {
            int value = reservedDays*Convert.ToInt32(suite.Price);

            if (reservedDays < 10)
            {
                return value;
            }

            return value * (1 - (10 / 100));
        }
    
    }
}
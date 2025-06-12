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
                Console.WriteLine($"Nova reserva feita com sucesso!");
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

        public string CalculatePrice(int reservedDays, Suite suite)
        {
            decimal value = 0;
            LuxurySuite? luxurySuite = suite as LuxurySuite;
            BasicSuite? basicSuite = suite as BasicSuite;

            switch (suite.Type)
            {
                case "Luxury":
                    Console.WriteLine("Jacuzzi inclusa? (true/false) - Taxa extra diária de R$50,00");
                    bool inputHasJacuzzi = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Café da manhã incluso? (true/false) - Taxa extra diária de R$30,00");
                    bool inputIncludesBreakfast = Convert.ToBoolean(Console.ReadLine());

                    if (inputHasJacuzzi)
                    {
                        value += reservedDays * Convert.ToInt32(luxurySuite?.ValueJacuzziDay);
                    }

                    if (inputIncludesBreakfast)
                    {
                        value += reservedDays * Convert.ToInt32(luxurySuite?.ValueBreakfastDay);
                    }

                    value += reservedDays * Convert.ToInt32(luxurySuite?.Price);
                    break;

                case "Basic":
                    value += reservedDays*Convert.ToInt32(basicSuite?.Price);
                    break;

                default:
                    throw new Exception("Tipo de suite inválido!");
            }

            if (reservedDays >= 10)
            {
                return (value *= 0.9M).ToString("C", new System.Globalization.CultureInfo("pt-BR")); //calcula o valor de 10% de desconto por dentro
            }

            return value.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
        }
    
    }
}
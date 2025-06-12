
using console_hotel_system.Models;

List<Guest> guests = new List<Guest>();

Guest g1 = new Guest(
    Guid.NewGuid().ToString(),
    "João da Silva",
    28,
    "08/10/1996",
    "male",
    "Rua da esquina, 000, SBC, SP",
    "11999999999",
    "emal@email.com",
    Guid.NewGuid().ToString()
);

Guest g2 = new Guest(
    Guid.NewGuid().ToString(),
    "Maria de Oliveira",
    25,
    "04/02/2000",
    "female",
    "Rua da esquina, 000, SBC, SP",
    "11999999999",
    "emal@email.com",
    Guid.NewGuid().ToString()
);

guests.Add(g1);
guests.Add(g2);


try
{
    Console.WriteLine("Qual tipo de Suite você deseja? \nBasic \nLuxury");

    string input = Console.ReadLine();
    
    switch (input)
    {
        case "Basic":
            BasicSuite basicSuite = new BasicSuite(Guid.NewGuid().ToString());
            break;

        case "Luxury":
            LuxurySuite luxurySuite = new LuxurySuite(Guid.NewGuid().ToString());
            break;

        default:
            break;
    }
}
catch (System.Exception)
{
    
    throw;
}

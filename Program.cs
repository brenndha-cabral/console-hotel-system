
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

    Suite suite = null!;

    string? input = Console.ReadLine();

    switch (input)
    {
        case "Basic":
            suite = new BasicSuite(Guid.NewGuid().ToString());
            break;

        case "Luxury":
            suite = new LuxurySuite(Guid.NewGuid().ToString());
            break;

        default:
            break;
    }

    Reserve reserve = new Reserve(Guid.NewGuid().ToString(), 5, DateTime.Now.ToString("dd/MM/yyyy - HH:mm"));

    reserve.RegisterReserve(guests, suite);

    Console.WriteLine($"Hóspedes: {reserve.GetAllGuests}");
    Console.WriteLine($"Valor total: {reserve.CalculatePrice}");

}
catch (Exception)
{

    throw new Exception("Erro ao rodar o projeto!");
}

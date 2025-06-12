
using console_hotel_system.Models;

List<Guest> guests = new List<Guest>();
bool hasRunProgram = true;

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
    while (hasRunProgram)
    {
        Console.WriteLine("\n🏨 Bem-vindo ao Chuckle Chateau! 🏨\n");
        Console.WriteLine("Escolha uma opção de suíte:\n\n🛏️ Basic\n🛏️ Luxury\n❌ Sair\n");


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

            case "Sair":
                Console.WriteLine("🏨 Chuckle Chateau agradece seu contato! Volte sempre! 🏨");
                hasRunProgram = false;
                break;

            default:
                break;
        }

        Console.WriteLine("\n🏨 Quantos dias serão reservados?");
        int inputDay = Convert.ToInt32(Console.ReadLine());

        Reserve reserve = new Reserve(Guid.NewGuid().ToString(), 5, DateTime.Now.ToString("dd/MM/yyyy - HH:mm"));

        reserve.RegisterReserve(guests, suite);

        List<Guest> allGuests = reserve.GetAllGuests();

        foreach (var guest in allGuests)
        {
            Console.WriteLine($"👤 Hóspedes: {guest.FullName} - Reserva {guest.Id}");
        }

        Console.WriteLine($"💰 Valor total: {reserve.CalculatePrice(inputDay, suite)}");
    }


}
catch (Exception)
{
    throw new Exception("Erro ao rodar o projeto!");
}

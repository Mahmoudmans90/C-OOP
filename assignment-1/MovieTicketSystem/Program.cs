using MovieTicketSystem; 

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Movie Ticket Booking System ===\n");

        Console.Write("Enter Movie Name: ");
        string movieName = Console.ReadLine()?? "";
        while (string.IsNullOrWhiteSpace(movieName))
        {
        Console.Write("Enter Movie Name: ");
        movieName = Console.ReadLine() ?? "";    
        }

        Console.Write("Enter Ticket Type (Standard, VIP, IMAX) or leave empty for default: ");
        string? typeInput = Console.ReadLine() ?? "";
        TicketType type = TicketType.Standard;
        if (!string.IsNullOrWhiteSpace(typeInput))
        {
            Enum.TryParse(typeInput, true, out type);
        }

        Console.Write("Enter Seat Row (A-Z) or leave empty for default: ");
        string? rowInput = Console.ReadLine();
        char row = 'A';
        if (!string.IsNullOrWhiteSpace(rowInput))
            row = char.ToUpper(rowInput[0]);

        Console.Write("Enter Seat Number or leave empty for default: ");
        string? numberInput = Console.ReadLine();
        int seatNumber = 1;
        if (int.TryParse(numberInput, out int n))
            seatNumber = n;

        Seat seat = new Seat(row, seatNumber);

        Console.Write("Enter Price or leave empty for default: ");
        string? priceInput = Console.ReadLine();
        double price = 50;
        if (double.TryParse(priceInput, out double p))
            price = p;

        Ticket ticket = new Ticket(movieName, type, seat, price);

        Console.Write("Enter Discount Amount (if any) or leave empty: ");
        string? discountInput = Console.ReadLine();
        double discount = 0;
        if (double.TryParse(discountInput, out double d))
            discount = d;
     
        ticket.PrintTicket(discount);


        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

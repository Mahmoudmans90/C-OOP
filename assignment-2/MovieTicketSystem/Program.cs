using MovieTicketSystem; 


class Program
{
    static void Main()
    {
        Cinema cinema = new Cinema();

        Console.WriteLine("=== Movie Ticket Booking System ===");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nEnter details for Ticket {i + 1}:");

            Console.Write("Movie Name: ");
            string movieName = Console.ReadLine();

            Console.Write("Ticket Type (Standard/VIP/IMAX): ");
            string typeStr = Console.ReadLine();
            TicketType type = Enum.TryParse(typeStr, true, out TicketType tResult) ? tResult : TicketType.Standard;

            Console.Write("Seat Row: ");
            string row = Console.ReadLine();

            Console.Write("Seat Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Ticket ticket = new Ticket(movieName , type ,new Seat(row[0] , number) , price);

            bool added = cinema.addTicket(ticket);
            if (!added)
                Console.WriteLine("Cinema is full. Cannot add more tickets.");
        }

        Console.WriteLine("\n--- Tickets ---");
        for (int i = 0; i < 3; i++)
        {
            Ticket t = cinema[i];
            if (t != null)
                Console.WriteLine(t);
        }

        Console.Write("\nEnter movie name to search: ");
        string searchName = Console.ReadLine();
        Ticket found = cinema.GetMovie(searchName);
        Console.WriteLine(found != null ? $"Found: {found}" : "Movie not found.");

        Console.WriteLine($"\nTotal Tickets Sold: {Ticket.getTotaleTicketsCount()}");

        Console.WriteLine($"\nBooking Reference 1: {BookingHelper.genrateBookingRegerence()}");
        Console.WriteLine($"Booking Reference 2: {BookingHelper.genrateBookingRegerence()}");

        double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
        Console.WriteLine($"Group of 5 tickets at 80 EGP each. Total after discount (if applicable): {groupTotal:C}");
    }
}


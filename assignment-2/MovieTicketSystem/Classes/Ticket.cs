namespace MovieTicketSystem
{
    public class Ticket
    {
      
        private string movieName;
        private TicketType type;
        private Seat seat;
        private double price;
        public int TicketId {get;init;}
        private static int ticketCounter = 0;
        
        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;  
            Type = type;
            Seat = seat;
            Price = price;
            TicketId = ++ticketCounter;
        }

        public static int getTotaleTicketsCount () => ticketCounter; 
        public Ticket(string movieName)
            : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        {
        }

     
        public string MovieName
        {
            get => movieName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    movieName = value;
             
            }
        }

        public TicketType Type
        {
            get => type;
            set => type = value;
        }

        public Seat Seat
        {
            get => seat;
            set => seat = value; 
        }

        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public double PriceAfterTax => price * 1.14;

        public void ApplyDiscount(double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= price)
                price -= discountAmount;
        }

        public void PrintTicket(double discount)
        {
            Console.WriteLine("------ Ticket Info ------");
            Console.WriteLine($"Movie Name: {MovieName}");
            Console.WriteLine($"Ticket Type: {Type}");
            Console.WriteLine($"Seat: {Seat}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Price + Tax: {PriceAfterTax}");

            ApplyDiscount(discount);

            Console.WriteLine("------ After Discount ------");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Price + Tax: {PriceAfterTax}");
            Console.WriteLine("------------------------");
        }
    }
}
namespace MovieTicketSystem
{
    public class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; }
        private double Price { get; set; }

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string movieName) 
            : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        {
        }
        public double CalcTotal()
        {
            double total = Price + (Price * 14 / 100);
            return total;
        }
        public void ApplyDiscount(double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;   
                discountAmount = 0;        
            }
        }
        public void PrintTicket(double discount)
        {
            Console.WriteLine("------ Ticket Info ------");
            Console.WriteLine($"Movie Name: {MovieName}");
            Console.WriteLine($"Ticket Type: {Type}");
            Console.WriteLine($"Seat: {Seat}");
            double total = this.CalcTotal();
            Console.WriteLine($"Price + (14%) Tax: {total} ");
            Console.WriteLine("------------------------");
            Console.WriteLine("------ After Discount ------");
            this.ApplyDiscount(discount);
            Console.WriteLine($"Discount pefore: {discount}");
            Console.WriteLine($"Discount after: 0");
            Console.WriteLine($"Movie Name: {MovieName}");
            Console.WriteLine($"Ticket Type: {Type}");
            Console.WriteLine($"Seat: {Seat}");
            Console.WriteLine($"Price: {Price}");
            double total2 = this.CalcTotal();
            Console.WriteLine($"Price + (14%) Tax: {total2} ");
            Console.WriteLine("------------------------");
        }
    }
}
using System.Diagnostics.Metrics;

namespace MovieTicketSystem
{
    public class Ticket
    {
        private static int Counter = 1;
        public int TicketId {get;init;}

        public string MovieName {get;set;}

        private decimal price;

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("price must be greater than 0");
                }
                    this.price = value;
            }
        }

        public void setPrice(decimal price)
        {
            this.Price= price;
        }
        public void setPrice(decimal price , decimal multiplier)
        {
            this.Price = price * multiplier;
        }

        public Ticket (string movieName , decimal price)
        {
            this.MovieName = movieName;
            Price = price;
            TicketId = Counter++;
        }


        public decimal PriceAfterTax
        {
            get
            {
                return price * 1.14m;
            }
        }


        public virtual string printTicket()
        {
           return $"Tiket-ID : {TicketId} , movie name :{MovieName} , price :{Price} , price After taxs : {PriceAfterTax}";
        }


    }
}
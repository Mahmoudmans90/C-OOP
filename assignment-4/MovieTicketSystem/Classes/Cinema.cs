namespace MovieTicketSystem
{
    public class Cinema
    {
        public string CinemaName {get;set;}
        private Projector projector;
        public Ticket[] Tickets = new Ticket[20];
        public Cinema(string cinemaName)
        {
            projector = new Projector();
            this.CinemaName = cinemaName;
        }

        public bool addTicket(Ticket t)
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i] == null)
                {
                    Tickets[i] = t;
                    return true;
                }
            }
            Console.WriteLine("Cinema Is Full Cannot add new ticket");
            return false;
        }
        public void printAllteckets()
        {
            foreach (var t in Tickets)
            {
                if (t != null)
                {
                    Console.WriteLine(t.printTicket());
                }
            }
        }
        public void openCinema()
        {
            Console.WriteLine($"{CinemaName} is Now Open .");
            projector.start();
        }
        public void closeCinema()
        {
            Console.WriteLine($"{CinemaName} is Now Closed .");
            projector.stop();
        }
    }
}
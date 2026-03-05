

namespace MovieTicketSystem
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        public Ticket? this[int index]
        {
            get
            {
                if (index < 0 ||index >= tickets.Length)
                    return null;
            
                return tickets[index];
            }
            set
            {
                if (index >= 0 || index < tickets.Length)
                    tickets[index] = value!;
                
            }
        }

        public Ticket? GetMovie(string movieName)
        {
            foreach (var ticket in tickets)
            {
                if (ticket != null && ticket.MovieName.Equals(movieName))
                {
                    return ticket;
                }
            }
                return null;
        }
        public Boolean addTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                } 
            }
            return false;
        }
    }
}
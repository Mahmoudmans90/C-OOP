namespace MovieTicketSystem
{
    public class VipTicket : Ticket
    {
        
        public bool loungeAxies{get;set;}
        public decimal SearviceFees {get;} = 50;

        public VipTicket(string movieName , decimal price ,bool loungeAxies ):base(movieName , price)
        {
            this.loungeAxies = loungeAxies;
        }
        public override string ToString()
        {
            return base.ToString() + $" lounge Axies :{loungeAxies} ,  service fees : {SearviceFees}";
        }
    }
}
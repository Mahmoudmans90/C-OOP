
namespace MovieTicketSystem
{
    public class StanderdTicket : Ticket
    {
        public string SeateNumper {get;set;}
        public StanderdTicket(string movieName ,decimal price , string seateNum ):base(movieName , price)
        {
            SeateNumper = seateNum;
        }

        public override string printTicket()
        {
            return $"{base.printTicket()} Seate Number :{SeateNumper}";
        }
    }
}
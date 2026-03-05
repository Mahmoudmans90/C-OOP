
namespace MovieTicketSystem
{
    public class StanderdTicket : Ticket
    {
        public string SeateNumper {get;set;}
        public StanderdTicket(string movieName ,decimal price , string seateNum ):base(movieName , price)
        {
            SeateNumper = seateNum;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Seate Number :{SeateNumper}";
        }
    }
}
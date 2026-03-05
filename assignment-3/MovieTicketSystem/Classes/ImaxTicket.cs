namespace MovieTicketSystem
{
    public class ImaxTicket :Ticket
    {
        public bool Is3d {get;set;}
        public ImaxTicket (string moviename , decimal price , bool isrd) : base(moviename , price)
        {
            this.Is3d = isrd;
            if (Is3d)
            {
                price += 30;
            }
        }


        public override string ToString()
        {
            return base.ToString() + $" , 3D : {Is3d}";
        }
    }
}
using MovieTicketSystem; 


class Program
{
    static void Main()
    {
        Cinema cinema = new Cinema("Glaxy");
        cinema.openCinema();
        StanderdTicket standerd = new StanderdTicket("Avengers" , 100 , "A5");
        VipTicket vip = new VipTicket("batman dark knight" , 150 ,true);
        ImaxTicket imax = new ImaxTicket("Avtar" , 200 , true);
        cinema.addTicket(vip);
        cinema.addTicket(standerd);
        cinema.addTicket(imax);
        cinema.printAllteckets();
        cinema.closeCinema();
   }
}


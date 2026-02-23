
namespace MovieTicketSystem
{
    public struct Seat
    {
        public char Row { get; set; }   
        public int Number { get; set; }

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }

       
        public override string ToString()
        {
            return $"{Row}{Number}";
        } 
    }
}

namespace MovieTicketSystem
{
    public static class BookingHelper
    {
        private static int BookingCounter =0;

        public static double CalcGroupDiscount(int number , double price)
        {
            double total = number * price;
            if (number >= 5)
            {
                 total *=  0.9;
            }
            return total;
        }

        public static string genrateBookingRegerence()
        {
            BookingCounter++;
            return $"BK-{BookingCounter}";
        }
    }
}
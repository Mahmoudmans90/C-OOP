namespace Assignment_1
{
    public class Car
    {
        public string? Model;
        private double price;

        public void SetPrice(double p)
        {
            if (p > 0)
                price = p;
        }

        public double GetPrice()
        {
            return price;
        }
        public Car(string model , double price)
        {
            this.Model = model;
            this.price = price;
        }
    }
}
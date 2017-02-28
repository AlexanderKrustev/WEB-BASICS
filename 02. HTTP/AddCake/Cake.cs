namespace AddCake
{
    using System;

    public class Cake
    {
        public Cake(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public String Name { get; set; }

        public Decimal Price { get; set; }
    }
}

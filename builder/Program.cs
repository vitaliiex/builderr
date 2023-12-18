namespace builder
{
    public class Laptop
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }  
        public string OS { get; set; }
        public int Price { get; set; }
        private Laptop() { }
        public class Builder
        {
            private Laptop laptop = new Laptop();

            public Builder WithName(string name)
            {
                laptop.Name = name;
                return this;
            }
            public Builder WithModel(string model)
            {
                laptop.Model = model;
                return this;
            }
            public Builder WithYear(int year)
            {
                laptop.Year = year;
                return this;
            }
            public Builder WithOS(string os)
            {
                laptop.OS = os;
                return this;
            }
            public Builder WithPrice(int price)
            {
                laptop.Price = price;
                return this;
            }
            public Laptop Build()
            {
                return laptop;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop.Builder()
            .WithName("Lenovo")
            .WithModel("vfdfdbjbd2")
            .WithYear(2019)
            .WithOS("Windows")
            .WithPrice(29900)
            .Build();
            
        }
    }
}

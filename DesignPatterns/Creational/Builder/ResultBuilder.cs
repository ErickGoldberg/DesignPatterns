namespace DesignPatterns.Creational.Builder
{
    public class ResultBuilder
    {
        public Car car { get; set; }
        public ResultBuilder() 
        {
            CarBuilder builder = new CarBuilder();
            car = builder
                .SetMake("Toyota")
                .SetModel("Corolla")
                .SetYear(2020)
                .SetColor("Red")
                .SetSunroof(true)
                .Build();
        }

    }
}

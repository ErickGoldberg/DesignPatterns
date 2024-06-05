namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder
    {
        private Car _car = new Car();

        public CarBuilder SetMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarBuilder SetSunroof(bool sunroof)
        {
            _car.Sunroof = sunroof;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }

}

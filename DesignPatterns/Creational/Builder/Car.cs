namespace DesignPatterns.Creational.Builder
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public bool Sunroof { get; set; }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Color: {Color}, Sunroof: {Sunroof}";
        }
    }

}

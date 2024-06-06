namespace DesignPatterns.Structural.Bridge
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius, IColor color) : base(color)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Circle of radius {radius} with color {color.ApplyColor()}");
        }
    }

    public class Square : Shape
    {
        private double side;

        public Square(double side, IColor color) : base(color)
        {
            this.side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Square of side {side} with color {color.ApplyColor()}");
        }
    }

}

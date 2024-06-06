namespace DesignPatterns.Structural.Flyweight
{
    public class ShapeFactory
    {
        private Dictionary<string, Circle> _circles = new Dictionary<string, Circle>();

        public Circle GetCircle(string color)
        {
            if (!_circles.ContainsKey(color))
            {
                _circles[color] = new Circle(color);
                Console.WriteLine($"Creating a circle of color: {color}");
            }

            return _circles[color];
        }
    }

}

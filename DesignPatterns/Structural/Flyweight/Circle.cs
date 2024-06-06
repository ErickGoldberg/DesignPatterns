namespace DesignPatterns.Structural.Flyweight
{
    public class Circle : IShape
    {
        private string _color; 
        private int _radius = 5; 

        public Circle(string color)
        {
            _color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a {_color} circle at ({x}, {y}) with radius {_radius}");
        }
    }

}

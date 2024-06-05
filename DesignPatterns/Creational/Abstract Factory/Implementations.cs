namespace DesignPatterns.Creational.Abstract_Factory
{
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a modern chair.");
        }
    }

    public class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Victorian chair.");
        }
    }

    public class ModernTable : ITable
    {
        public void Use()
        {
            Console.WriteLine("Using a modern table.");
        }
    }

    public class VictorianTable : ITable
    {
        public void Use()
        {
            Console.WriteLine("Using a Victorian table.");
        }
    }

}

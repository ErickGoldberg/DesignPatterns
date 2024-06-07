namespace DesignPatterns.Behavioral.Template_Method
{
    public class WoodenHouseBuilder : HouseBuilder
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building wooden foundation.");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building wooden walls.");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("Building wooden roof.");
        }

        // Sobrescrevendo
        protected override void Decorate()
        {
            Console.WriteLine("Adding wooden decorations.");
        }
    }

    public class ConcreteHouseBuilder : HouseBuilder
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building concrete foundation.");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building concrete walls.");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("Building concrete roof.");
        }
    }

}

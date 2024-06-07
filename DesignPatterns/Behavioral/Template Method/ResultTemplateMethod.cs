namespace DesignPatterns.Behavioral.Template_Method
{
    public class ResultTemplateMethod
    {
        public ResultTemplateMethod()
        {
            HouseBuilder woodenHouseBuilder = new WoodenHouseBuilder();
            woodenHouseBuilder.BuildHouse();

            Console.WriteLine();

            HouseBuilder concreteHouseBuilder = new ConcreteHouseBuilder();
            concreteHouseBuilder.BuildHouse();
        }
    }
}

namespace DesignPatterns.Behavioral.Template_Method
{
    public abstract class HouseBuilder
    {
        // Esqueleto do processo
        public void BuildHouse()
        {
            BuildFoundation();
            BuildWalls();
            BuildRoof();
            Decorate();
            Console.WriteLine("House construction completed.");
        }

        protected abstract void BuildFoundation();
        protected abstract void BuildWalls();
        protected abstract void BuildRoof();

        // Opcional
        protected virtual void Decorate()
        {
            Console.WriteLine("Decorating the house.");
        }
    }
}

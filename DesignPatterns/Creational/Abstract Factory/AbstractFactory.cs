namespace DesignPatterns.Creational.Abstract_Factory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }

}

namespace DesignPatterns.Creational.Factory_Method
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }

    public class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }

    public class CatFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }

}

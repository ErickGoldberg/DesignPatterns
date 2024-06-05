namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        private Singleton()
        {
            // Inicialização do singleton.
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance doing something!");
        }
    }

}

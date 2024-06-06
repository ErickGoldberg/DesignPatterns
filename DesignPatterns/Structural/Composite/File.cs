namespace DesignPatterns.Structural.Composite
{
    public class File : IFileSystemComponent
    {
        public string Name { get; }

        public File(string name)
        {
            Name = name;
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}- {Name}");
        }
    }

}

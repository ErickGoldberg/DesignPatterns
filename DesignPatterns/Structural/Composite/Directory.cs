namespace DesignPatterns.Structural.Composite
{
    public class Directory : IFileSystemComponent
    {
        public string Name { get; }
        private readonly List<IFileSystemComponent> _components = new List<IFileSystemComponent>();

        public Directory(string name)
        {
            Name = name;
        }

        public void AddComponent(IFileSystemComponent component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(IFileSystemComponent component)
        {
            _components.Remove(component);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}+ {Name}");
            foreach (var component in _components)
            {
                component.Display(indent + "  ");
            }
        }
    }

}

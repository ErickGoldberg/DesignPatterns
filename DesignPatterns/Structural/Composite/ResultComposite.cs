namespace DesignPatterns.Structural.Composite
{
    public class ResultComposite
    {
        public ResultComposite()
        {
            var file1 = new File("File1.txt");
            var file2 = new File("File2.txt");
            var file3 = new File("File3.txt");

            var rootDirectory = new Directory("Root");
            var subDirectory1 = new Directory("SubDirectory1");
            var subDirectory2 = new Directory("SubDirectory2");

            // Montando a estrutura de diretórios e arquivos
            rootDirectory.AddComponent(file1);
            rootDirectory.AddComponent(subDirectory1);

            subDirectory1.AddComponent(file2);
            subDirectory1.AddComponent(subDirectory2);

            subDirectory2.AddComponent(file3);


            rootDirectory.Display("");
        }
    }
}

namespace DesignPatterns.Behavioral.Visitor
{
    public class ResultVisitor
    {
        public ResultVisitor()
        {
            List<IDocumentElement> documentElements = new List<IDocumentElement>
            {
                new TextElement("Hello World"),
                new ImageElement("/path/to/image.jpg"),
                new TextElement("This is a Visitor pattern example."),
                new TableElement(3, 5)
            };

            RenderVisitor renderVisitor = new RenderVisitor();
            WordCountVisitor wordCountVisitor = new WordCountVisitor();

            foreach (var element in documentElements)
            {
                element.Accept(renderVisitor);
                element.Accept(wordCountVisitor);
            }

            Console.WriteLine($"Total Word Count: {wordCountVisitor.WordCount}");
        }
    }
}

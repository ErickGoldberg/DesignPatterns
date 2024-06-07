namespace DesignPatterns.Behavioral.Visitor
{
    public class RenderVisitor : IDocumentVisitor
    {
        public void Visit(TextElement textElement)
        {
            Console.WriteLine($"Rendering Text: {textElement.Text}");
        }

        public void Visit(ImageElement imageElement)
        {
            Console.WriteLine($"Rendering Image: {imageElement.ImagePath}");
        }

        public void Visit(TableElement tableElement)
        {
            Console.WriteLine($"Rendering Table: {tableElement.Rows} rows, {tableElement.Columns} columns");
        }
    }

    public class WordCountVisitor : IDocumentVisitor
    {
        public int WordCount { get; private set; } = 0;

        public void Visit(TextElement textElement)
        {
            WordCount += textElement.Text.Split(' ').Length;
        }

        public void Visit(ImageElement imageElement)
        {
        }

        public void Visit(TableElement tableElement)
        {
        }
    }
}

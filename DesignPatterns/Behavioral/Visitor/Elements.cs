namespace DesignPatterns.Behavioral.Visitor
{
    public class TextElement : IDocumentElement
    {
        public string Text { get; }

        public TextElement(string text)
        {
            Text = text;
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ImageElement : IDocumentElement
    {
        public string ImagePath { get; }

        public ImageElement(string imagePath)
        {
            ImagePath = imagePath;
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class TableElement : IDocumentElement
    {
        public int Rows { get; }
        public int Columns { get; }

        public TableElement(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}

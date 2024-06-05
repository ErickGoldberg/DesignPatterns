namespace DesignPatterns.Creational.Prototype
{
    public abstract class Document : ICloneable<Document>
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Document(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public abstract Document Clone();

        public override string ToString()
        {
            return $"Title: {Title}, Content: {Content}";
        }
    }

}

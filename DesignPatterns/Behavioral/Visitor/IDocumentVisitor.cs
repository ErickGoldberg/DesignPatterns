namespace DesignPatterns.Behavioral.Visitor
{
    public interface IDocumentVisitor
    {
        void Visit(TextElement textElement);
        void Visit(ImageElement imageElement);
        void Visit(TableElement tableElement);
    }
}

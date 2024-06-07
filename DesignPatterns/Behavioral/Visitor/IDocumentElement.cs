namespace DesignPatterns.Behavioral.Visitor
{
    public interface IDocumentElement
    {
        void Accept(IDocumentVisitor visitor);
    }
}

namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator<T>
    {
        T Current();
        bool MoveNext();
    }

}

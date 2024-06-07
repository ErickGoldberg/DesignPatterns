namespace DesignPatterns.Behavioral.Iterator
{
    public class MyList<T>
    {
        private List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);
        }

        public IIterator<T> GetIterator()
        {
            return new ListIterator<T>(_list);
        }
    }

}

namespace DesignPatterns.Behavioral.Iterator
{
    public class ListIterator<T> : IIterator<T>
    {
        private List<T> _list;
        private int _index = 0;

        public ListIterator(List<T> list)
        {
            _list = list;
        }

        public T Current()
        {
            return _list[_index];
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _list.Count;
        }
    }

}

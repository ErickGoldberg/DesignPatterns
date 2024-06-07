namespace DesignPatterns.Behavioral.Iterator
{
    public class ResultIterator
    {
        public ResultIterator()
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            IIterator<int> iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current());
            }
        }
    }
}

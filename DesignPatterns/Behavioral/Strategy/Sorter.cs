namespace DesignPatterns.Behavioral.Strategy
{
    public class Sorter
    {
        private ISortStrategy _strategy;

        public Sorter(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Sort(int[] array)
        {
            _strategy.Sort(array);
        }
    }

}

namespace DesignPatterns.Behavioral.Strategy
{
    public class ResultStrategy
    {
        public ResultStrategy()
        {
            int[] array = { 5, 3, 8, 1, 2, 4, 7, 6 };

            Sorter sorter = new Sorter(new BubbleSortStrategy());
            sorter.Sort(array);

            sorter.SetStrategy(new QuickSortStrategy());
            sorter.Sort(array);

            sorter.SetStrategy(new MergeSortStrategy());
            sorter.Sort(array);
        }
    }
}

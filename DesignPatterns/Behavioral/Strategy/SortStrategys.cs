namespace DesignPatterns.Behavioral.Strategy
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using Bubble Sort");
        }
    }

    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using Quick Sort");
        }
    }

    public class MergeSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using Merge Sort");
        }
    }

}

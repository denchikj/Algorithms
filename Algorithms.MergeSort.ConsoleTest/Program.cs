namespace Algorithms.MergeSort.ConsoleTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 3, 9, 10, 15, 12, 6, 20, 199, -10 };
            foreach (int i in Implementations.MergeSort.SortMerge(array))
            {
                Console.Write(i + " ");
            }
        }
    }
}
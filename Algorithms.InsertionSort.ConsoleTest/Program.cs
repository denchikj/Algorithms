namespace Algorithms.InsertionSort.ConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 3, 9, 10, 15, 12, 6, 20, 199, -10 };
            foreach (int i in Implementations.InsertionSort.SortInsertion(array))
            {
                Console.Write(i + " ");
            }
        }
    }
}
using Algorithms.BinarySearch.Implementations;

namespace Algorithms.BinarySearch.ConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = new[] { 2, 5, 6, 7, 12, 14, 17, 19, 25, 36, 43, 64, 67, 78, 79 };
            Console.WriteLine(Implementations.BinarySearch.Search(n, 14));
            Console.WriteLine(Implementations.BinarySearch.Search(n, 67));
        }
    }
}
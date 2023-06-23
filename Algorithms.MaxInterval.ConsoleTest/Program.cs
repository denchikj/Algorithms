namespace Algorithms.MaxInterval.ConsoleTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var arr = new[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            var max = MaximumSubarray.MaxSubarray.MaximumSubarray.KadaneAlgorithm(arr);
            Console.WriteLine($"Maximum sub sum: {max}");

            var subarray = IntervalFinder.FindInterval(arr, max);
            foreach (var value in subarray)
            {
                Console.Write(value + " ");
            }
        }
    }
}
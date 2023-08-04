namespace Algorithms.ExponentialSearch
{
    internal class Program
    {
        private static int ExponentialSearch(int[] arr, int n, int x)
        {
            if (arr[0] == x)
                return 0;

            int i = 1;
            while (i < n && arr[i] <= x)
                i = i * 2;

            return BinarySearch(arr, i / 2, Math.Min(i, n - 1), x);
        }

        private static int BinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);

                return BinarySearch(arr, mid + 1, r, x);
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 44, 50 };
            int n = arr.Length;
            int x = 3;
            int result = ExponentialSearch(arr, n, x);
            if (result == -1)
                Console.WriteLine($"element is not present in array");
            else
                Console.WriteLine($"element is present at index {result}");
        }
    }
}
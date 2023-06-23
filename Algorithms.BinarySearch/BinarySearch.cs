namespace Algorithms.BinarySearch.Implementations
{
    public class BinarySearch
    {

        public static int Search(int[] input, int element)
        {
            return Search(input, 0, input.Length - 1, element);
        }

        private static int Search(int[] input, int v1, int v2, int element)
        {
            while (true)
            {
                if (v1 == v2) 
                {
                    if (input[v1] == element) return v1;
                    return -1;
                }

                var mid = (v1 + v2) / 2;
                if (input[mid] == element) return mid;

                if (input[mid] > element)
                {
                    v2 = mid;
                    continue;
                }

                v1 = mid + 1;
            }
        }
    }
}
namespace Algorithms.QuickSort.Implementations
{
    public class QuickSort
    {
        public static int[] SortQuick(int[] array)
        {
            if (array.Length <= 1) return array;

            QuickSortRecursion(array, 0, array.Length - 1);

            return array;
        }

        private static void QuickSortRecursion(int[] array, int start, int end)
        {
            if (end < start) return;

            int pivot = start;
            int left = start + 1;
            int right = end;

            while (right >= left)
            {
                if (array[left] > array[pivot] && array[right] < array[pivot])
                {
                    Swap(array, left, right);
                }
                if (array[left] <= array[pivot])
                {
                    left++;
                }
                if (array[right] >= array[pivot])
                {
                    right--;
                }
            }
            Swap(array, pivot, right);
            QuickSortRecursion(array, right + 1, end);
            QuickSortRecursion(array, start, right - 1);
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
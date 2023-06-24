namespace Algorithms.InsertionSort.Implementations
{
    public class InsertionSort
    {
        public static int[] SortInsertion(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }

            return array;
        }
    }
}
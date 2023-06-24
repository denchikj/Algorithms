namespace Algorithms.SelectionSort.Implementations
{
    public class SelectionSort
    {
        public static int[] SortSelection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                int temp = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                array[i] = array[min];
                array[min] = temp;
            }

            return array;
        }
    }
}
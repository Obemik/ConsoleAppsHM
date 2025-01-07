using System;

namespace ArraySorter
{
    public static class Sorter
    {
        public static int[] Sort(int[] array, bool ascending = true)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((ascending && array[i] > array[j]) || (!ascending && array[i] < array[j]))
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
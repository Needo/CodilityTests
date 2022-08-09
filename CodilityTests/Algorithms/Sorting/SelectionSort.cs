namespace CodilityTests.Algorithms.Sorting
{
    /// <summary>
    /// It selects the smalles element of an unsorted array in each iteration and places it at the beginning of the array.
    /// e.g 25,22,15,8,12,2. in first iteration it will swap 25 with 2 since, 2 is the smallest.
    /// Time Complexity: O(n2)
    /// </summary>
    internal class SelectionSort
    {
        public static void Sort(int[] a)
        {
            int size = a.Length;

            for (int index = 0; index < size - 1; index++)
            {
                int element = index;
                for (int i = index + 1; i < size; i++)
                {
                    if (a[i] < a[element])
                    {
                        element = i;
                    }
                }

                int temp = a[element];
                a[element] = a[index];
                a[index] = temp;
            }
        }
    }
}
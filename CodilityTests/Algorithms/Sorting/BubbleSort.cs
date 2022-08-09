namespace CodilityTests.Algorithms.Sorting
{
    /// <summary>
    /// Compares two adjacent elements and swap until all elements are in the desired order (ascending or descending).
    /// Time Complexity: O(n2) as there are two loops (nested) 
    /// </summary>
    public class BubbleSort
    {
        public static void Sort(int[] a)
        {
            var size = a.Length;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Swap(a, j);
                }
            }
        }

        private static void Swap(int[] a, int j, bool Ascending = true)
        {
            if (Ascending)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
            else
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }
}
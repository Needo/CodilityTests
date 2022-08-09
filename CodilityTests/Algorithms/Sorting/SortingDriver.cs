using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests.Algorithms.Sorting
{
    internal static class SortingDriver
    {
        public static void Run()
        {
            int[] bubbleData = { -2, 45, 0, 11, -9 };
            BubbleSort.Sort(bubbleData);
            Console.WriteLine($"Bubble Sort:{string.Join(",", bubbleData)}");

            int[] selectionData = { -2, 45, 0, 11, -9 };
            //int [] selectionData = { 20, 12, 10, 15, 2 };
            SelectionSort.Sort(selectionData);
            Console.WriteLine($"Selection Sort:{string.Join(",", selectionData)}");

            Console.ReadLine();
        }
    }
}

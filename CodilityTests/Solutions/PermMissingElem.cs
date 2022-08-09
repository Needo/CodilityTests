using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests.Solutions
{
    internal static class PermMissingElem
    {
        //9,2, 3, 1, 5
        internal static int Solutions(int[] A)
        {
            int index = 0;

            //Sort array elements in ascending order.
            while (index < A.Length)
            {
                //if current element is equal to indexer or current element value is greater than array length then leave the element value as it is
                if (A[index] == index + 1 || A[index] > A.Length)
                    index++;
                else //Swap the value
                {
                    int temp = A[index];//store in temp
                    int position = A[index] - 1;
                    A[index] = A[position]; // subtract 1 from current index and replace the current index value
                                             // since, its greater than indexer and which is less than the current element value. 
                    A[position] = temp;

                    //swap(A, index, A[index] - 1);
                }
            }
            for (index = 0; index < A.Length; index++)
            {
                if (A[index] != index + 1)
                    return index + 1;
            }
            return A.Length + 1;
        }

        static void swap(int[] arr, int pos1, int pos2)
        {
            int temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }
    }   
}

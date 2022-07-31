namespace CodilityTests.Solutions
{
    public static class CyclicRotate
    {
        //[3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
        //[6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
        //[7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
        public static int[] solution(int[] A, int K)
        {
            int total = A.Length;
            int[] result = new int[total];

            //Empty input array, no rotation required.
            if (total == 0) return result;

            K = K % total;//3%5 means remainder is 3.

            int index = 0;
            //Copy x items equal to the number of iterations. i.e if iterations are 2 then copy the last two elements to the start of new array.
            //3 rotations means move last three elements to the start.
            for (int i = total - K; i < total; i++)
            {
                result[index++] = A[i];
            }
            // move/fill the remaining from the start of original array to the end of new array.
            for (int i = 0; i < total - K; i++)
            {
                result[index++] = A[i];
            }
            return result;
        }
    }
}
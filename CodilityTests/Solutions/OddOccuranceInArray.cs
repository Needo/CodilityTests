namespace CodilityTests.Solutions
{
    internal static class OddOccuranceInArray
    {
        //A[0] = 9  A[1] = 3  A[2] = 9
        //A[3] = 3  A[4] = 9  A[5] = 7
        //A[6] = 9
        public static int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in A)
            {
                //Removing means, it was added on first occurance and on second occurance is removed. that means, anything left at the end does not have pairs.
                if (set.Contains(num))
                    set.Remove(num);
                else
                    set.Add(num);
            }

            int result = (int)set.LastOrDefault(1);
            return result;
        }

        public static int solutionB(int[] A)
        {
            int monMatched = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                monMatched = monMatched ^ A[i];//if corresponding bits are same means numbers are equal then it returns 0 otherwise
            }
            return monMatched;
        }
    }
}
namespace CodilityTests.Solutions
{
    internal static class BinaryGap
    {
        public static int solution(int input)
        {
            int inputNumber = input;
            int result, gap, lastGap, numberOfGaps, remainder;
            result = gap = lastGap = numberOfGaps = remainder = 0;
            bool isFirstOnDigit = false;

            string binaryResult = "";
            while (inputNumber > 0)
            {
                remainder = inputNumber % 2;
                inputNumber = inputNumber / 2;

                binaryResult = remainder.ToString() + binaryResult;

                if (remainder == 1)
                {
                    if (!isFirstOnDigit)
                    {
                        isFirstOnDigit = true;
                    }
                    else
                    {
                        if (gap > 0)
                            numberOfGaps += 1;

                        if (gap > lastGap)
                            lastGap = gap;
                    }

                    gap = 0;
                }
                else
                    gap += 1;
            }

            if (numberOfGaps >= 1 && lastGap > 0)
                result = lastGap;
           
            return result;
        }
    }
}
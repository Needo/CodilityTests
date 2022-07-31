using CodilityTests.Solutions;
namespace CodilityTests
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Run();
            Console.Read();
        }
        private static void Run()
        {
            //Iterations
            int input = 1041;
            var res1 =BinaryGap.solution(input);
            Console.WriteLine($"BinaryGap for {input} is: {res1}");            

            //Arrays
            int[] B = { 9, 3, 9, 3, 9, 7, 9 };
            var resOdd = OddOccuranceInArray.solution(B);
            var resB = OddOccuranceInArray.solutionB(B);
            Console.WriteLine($"Odd number missing pair : {string.Join(",", resOdd)} | solution B: {string.Join(",", resB)}");

            //Arrays
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            var res2 = CyclicRotate.solution(A, K);
            Console.WriteLine($"After {K} rotatations : {string.Join(",", res2)}");

        }
    }
}
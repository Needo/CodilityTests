using CodilityTests.Solutions;
using CodilityTests.Algorithms.Sorting;
namespace CodilityTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Sorting
            SortingDriver.Run();

            Run();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static void Run()
        {
            int[] A2 = { 9, 2, 3, 1, 5 };
            var res4 = PermMissingElem.Solutions(A2);
            Console.WriteLine($"Missing number from {string.Join(",", A2)} : is: {res4}");

            var res3 = FrogJmp.solution(10, 85, 30);
            res3 = FrogJmp.solution(5, 105, 3);
            Console.WriteLine($"Minimum Jumps for [ x:10, Y:85, D:30 ] are: {res3}");

            //Iterations
            int input = 1041;
            var res1 = BinaryGap.solution(input);
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
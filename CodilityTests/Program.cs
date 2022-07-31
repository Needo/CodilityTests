using CodilityTests.Solutions;
namespace CodilityTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            var res=CyclicRotate.solution(A, K);
            Console.WriteLine($"After {K} rotatations : { string.Join(",",res) }");
















            Console.Read();
        }
    }
}
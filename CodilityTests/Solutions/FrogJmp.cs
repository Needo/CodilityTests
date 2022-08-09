using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests.Solutions
{
    internal static class FrogJmp
    {
        public static int solution(int X, int Y, int D)
        {
            int distance = Y - X;
            int jumps=distance / D;

            if(distance % D != 0)
                jumps++;

            return jumps;
        }
    }
}

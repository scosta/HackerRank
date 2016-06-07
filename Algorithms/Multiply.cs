using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class Multiply
    {
        public static int Compute(int x, int y)
        {
            int result = 0;

            while (y > 0)
            {
                if ((y & 1) == 1)
                {
                    result += x;
                }
                x = x << 1;
                y = y >> 1;
            }

            return result;
        }

        public static int Compute2(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }

            return Compute2(a << 1, b >> 1) + (((b & 1) == 1) ? a : 0);
        }
    }
}

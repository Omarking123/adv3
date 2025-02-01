using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv3
{
    internal class ConditionsFucntion
    {
        public static bool CheckOdd(int x)
        {
            return x % 2 != 0;
        }
        public static bool CheckEven(int x)
        {
            return x % 2 == 0;
        }
        public static bool Checkby4(int x)
        {
            return x % 4 == 0;
        }
    }
}

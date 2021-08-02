using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoParameters
{
    class Optional
    {
        public static int Two(int num1, int num2 = 1)
        {
            int result = num1 - num2;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathMethods
    {
        public static int Math(int userNumber)
        {
            int result = userNumber + 10;
            return result;
        }

        public static float Math(float userFloat)
        {
            float result = userFloat;
            return result;
        }

        public static int Math(string userString)
        {
            int result = Convert.ToInt32(userString);
            return result;
        }
    }
}

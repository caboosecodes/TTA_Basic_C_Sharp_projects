using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathMethods
    {
        // Overloading Methods
        
        // Method takes in an integer
        public static int RepeatMethod(int userNumber)
        {
            // adds 10
            int result = userNumber + 10;
            //returns the result
            return result;
        }

        // Method takes in a float
        public static float RepeatMethod(float userFloat)
        {
            // divides by 5
            float result = userFloat/5;
            // returns the result
            return result;
        }

        // Method takes in a float and returns an integer
        public static int RepeatMethod(string userString)
        {
            // converts a string to integer
            int result = Convert.ToInt32(userString);
            // returns the result
            return result;
        }
    }
}

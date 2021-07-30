using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{

    public class MathOperations
    {
        // Methods:

        // takes in the userNumber and adds 10 and returns the sum
        public static int Addition(int userNumber)
        {
            int add = userNumber + 10;
            return add;
        }

        // takes in the userNumber and subtracts 2 and returns the difference
        public static int Subtraction(int userNumber)
        {
            int sub = userNumber - 2;
            return sub;
        }
        
        // takes userNumber and multiplies it by 4 and returns the product
        public static int Multiplication(int userNumber)
        {
            int product = userNumber * 4;
            return product;
        }

    }
    
}

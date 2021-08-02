using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Class1
    {
        // void method with two parameters
        public void SomeMethod(int num1, int num2)
        {
            // math operation on num1  saved to variable result
            int result = num1 + 10;
            // prints to the terminal
            Console.WriteLine("{0} plus 10 equals {1}", num1, result);
            Console.WriteLine("Second parameter entered is {0}", num2);
            
        }
    }
}

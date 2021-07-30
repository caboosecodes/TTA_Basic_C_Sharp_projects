using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks the user to enter in a number
            Console.WriteLine("Please enter a number you would like to perform some math operations on");
            // saves that number in variable userNumber
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            // writes to the terminal using composite formatting
            // 
            Console.WriteLine("{0} plus 10 equals {1}", userNumber, MathOperations.Addition(userNumber));
            Console.WriteLine("{0} minus 2 equals {1}", userNumber, MathOperations.Subtraction(userNumber));
            Console.WriteLine("{0} multiplied by 4 equals {1}", userNumber, MathOperations.Multiplication(userNumber));
            Console.ReadLine();
        
        
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathMethods methods = new MathMethods();

            // Asks the user for input
            Console.WriteLine("Please input a whole number");
            // converts the string and saves input to integer variable
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // outputs a string with the userNumber variable and the result from the RepeatMethod in class MathMethods
            Console.WriteLine("{0} plus 10 equals {1}", userNumber, MathMethods.RepeatMethod(userNumber));

            // Asks the user for input
            Console.WriteLine("please input a decimal number");
            // converts the string to a float datatype and saves to variable
            float userFloat = float.Parse(Console.ReadLine());
            // outputs a string with userFloat and the result from the RepeatMethod in class MathMethods
            Console.WriteLine("{0} divided by 5 equals {1}", userFloat, MathMethods.RepeatMethod(userFloat));

            // Asks the user for input
            Console.WriteLine("Please input another whole number");
            // saves the string as a variable
            string userString = Console.ReadLine();
            // outputs a string with userString and the result from
            Console.WriteLine("Your input, {0}, was converted from a string to an integer, {1}", userString, MathMethods.RepeatMethod(userString));

            Console.ReadLine();

        }
    }
}

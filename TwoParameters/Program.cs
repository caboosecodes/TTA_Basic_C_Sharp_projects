using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int num1, num2;
            int result;

            // asks user for a number
            Console.WriteLine("Pick a number: ");
            // if the user input is not an accepted value of try parse
            // out lets the data value be passed to num1
            int.TryParse(Console.ReadLine(), out num1);
            
            // asks user to second number
            Console.WriteLine("Pick another number (optional)");
            // if user inputs a second number
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                // passes bothes parameters into the class method
                result = Optional.Two(num1, num2);
                Console.WriteLine("{0} minus {1} equals {2}", num1, num2, result);
            }
            // if the user doesn't input a number
            else
            {
                // it only passes the first number as the parameter
                result = Optional.Two(num1);
                Console.WriteLine("{0} minus 1 equals {1}", num1, result);
            }

            Console.ReadLine();

            //Console.WriteLine("Please input two numbers");
            //Console.Write("Number 1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number 2 (optional): ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            
            
            //Console.WriteLine("{0} minus {1} equals {2}", num1, num2, Optional.Two(num1, num2));
            //Console.ReadLine();
        }
    }
}

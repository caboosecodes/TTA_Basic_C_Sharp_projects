using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // initialize a list of integers named numbers
            List<int> numbers = new List<int>();
            // add numbers to that list
            numbers.Add(6);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(25);
            numbers.Add(45);
            numbers.Add(82);
            numbers.Add(94);

            try
            {
                // ask the user for a number
                Console.Write("Please select a non-zero number to divide by: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // iterates through numbers list
                foreach (int number in numbers)
                {
                    // divides the number in the list by the user's input
                    int division = number / userNumber;
                    // prints when the user inputs a whole number
                    Console.WriteLine(number + " divided by " + userNumber + " is equal to: " + division);
                }
            }
            // divide by zero error
            catch (DivideByZeroException ex)
            {
                // prints when the user tries to divide by zero
                Console.WriteLine("Don't divide by zero.");
            }
            // divide by non-number
            catch (FormatException ex)
            {
                // prints when the user inputs a non-number
                Console.WriteLine("Please type a whole number.");
            }
            // general exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // finally block runs no matter what
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

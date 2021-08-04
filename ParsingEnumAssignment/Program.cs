using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// needed to access the ToTitleCase method
using System.Globalization;

namespace ParsingEnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch block
            try
            {
                // asks the user for input
                Console.WriteLine("Please enter the current day of the week");
                // saves the input to variable currentDay
                string currentDay = Console.ReadLine();
                // upper cases the first letter of currentDay variable
                string uppercaseDay = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(currentDay);
                // instantiates Days enum as day
                Days day;

                // if statement
                /*** Enum.TryParse returns a boolean value; if the value parameter, uppercaseday, is successfully converted
                    to enum day, then it evaluates as true ***/
                if (Enum.TryParse<Days>(uppercaseDay, out day))
                {
                    // prints to the console
                    Console.WriteLine("Today is {0}", uppercaseDay);
                    Console.ReadLine();
                }
                else
                {
                    // if false then throws an exception
                    throw new Exception();
                }
            }
            // catches the exception
            catch (Exception ex)
            {
                // prints to the console when an exception is thrown
                Console.WriteLine("Hmmm, did you input a day? Did you spell the day correctly?");
            }
            finally
            {
                Console.ReadLine();
            }
            
        }

        // Enum of the days of the week
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

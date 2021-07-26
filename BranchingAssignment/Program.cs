// Branching Submission Assignemnt for the Tech Academy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Welcome to Pack Express. Please follow the instructions bewlow.");

            // asks user for package weight and stores it the variable
            Console.WriteLine("Please enter the package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            // nested branching statements
            if (packageWeight < 51)
            {
                // asks the user for the dimensions of the package
                Console.WriteLine("Please enter the package width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());
                int totalDimensions = width + height + length;
                
                // nested if statement to check if the sum of the dimensions is less than 50
                if (totalDimensions < 51)
                {
                    int quote = ((width * height * length) * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThank you!");
                }
                
                // if the totalDimension is greater than 50 then the following line is printed to the terminal
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
            }
            
            // if the packageWeight is greater than 50 then the following line is printed to terminal
            else
            {
                Console.WriteLine("Package too heavy to shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();













        }
    }
}

// Six part assignment

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIterationAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One: Append user input to string element in array
            // initializes an array "questions"
            string[] randomColors = { "Blue ", "Black ", "White ", "Red ", "Green ", "Yellow ", "Purple " };

            // Asks for user input and saves it to a variable
            Console.WriteLine("Please enter in a color");
            string userColor = Console.ReadLine();
            // for loop to iterate through the array

            // for loop
            for (int i= 0; i < randomColors.Length; i++)
            {
                // appends the userColor to the string at the index i in the array randomColors
                randomColors[i] = randomColors[i] + userColor;
                // Prints the string at the index i in the array randomColors
                Console.WriteLine(randomColors[i]);
            }

            // Part Two

            Console.ReadLine();
        }
    }
}

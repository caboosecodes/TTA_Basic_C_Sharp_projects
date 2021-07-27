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
            //// Part One: Append user input to string element in array
            //// initializes an array "questions"
            //string[] randomColors = { "Blue ", "Black ", "White ", "Red ", "Green ", "Yellow ", "Purple " };

            //// Asks for user input and saves it to a variable
            //Console.WriteLine("Please enter in a color");
            //string userColor = Console.ReadLine();
            //// for loop to iterate through the array

            //// for loop
            //for (int i= 0; i < randomColors.Length; i++)
            //{
            //    // appends the userColor to the string at the index i in the array randomColors
            //    randomColors[i] = randomColors[i] + userColor;
            //    // Prints the string at the index i in the array randomColors
            //    Console.WriteLine(randomColors[i]);
            //}


            // Part Two: Infinite Loop

            // x variable stores data type integer
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("Without incrementing x this will print indefinitely");
                // Need to add the increment to prevent infinite loop
                // to x++ where the value will be used then incremented as opposed ++x will increment then use the value
                x++;
            }


            // Part Three: Iterating using "<" and "<=" operator 
            
            // intializing integer variables
            int a = 0;
            int b = 0;
            
            // while loop using < operator
            while (a < 5)
            {
                //prints the value of a to the terminal
                Console.WriteLine(a);
                //increments a by 1
                a++;
            }
            // while loop using <= operator
            while (b <= 5)
            {
                // prints the value of b to the terminal
                Console.WriteLine(b);
                // increments b by 1
                b++;
            }


            Console.ReadLine();






            //// array of integers
            //int[] gameScores = { 100, 250, 600, 50, 850, 900, 400, 432, 1000, 950, 851 };
            //// for loop
            //for (int i = 0; i < gameScores.Length; i++)
            //{
            //    // loop
            //    if (gameScores[i] < 850)
            //    {
            //        Console.WriteLine(gameScores[i]);
            //    }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // a switch statement takes an input and checks it against a variety of preset values and performs the actions called for the value that matches
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            // comparison expression that will either return true or false
            bool isGuessed = number == 12;

            // the code inside the "do" will get done at least once
            do
            {
                // what we want to check goes inside the parentheses
                // switch statements revolves around cases
                switch (number)
                {
                    case 62:
                        Console.WriteLine("you guessed 62. Try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        // if you do not put break if will continue with the switch statment
                        break;
                    case 29:
                        Console.WriteLine("you guessed 29, Try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("you guessed 55, Try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("you guessed 12, that is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("you are worng!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // while loop
            // !isGuessed is the same as writing isGuessed == false
            while (!isGuessed);

            
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            // while loop
            int num = 1;
            // while the variable num is less than or equal to 5
            while (num <= 5)
            {
                // the "While Loop iteration" will print to the terminal
                Console.WriteLine("While Loop iteration #{0}", num);
                // increments the num variable as to not create an infinite loop
                num++;
            }
           

            // do while loop
            // asks the user for a number
            Console.WriteLine("please enter a number between 0 and 10");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isSix = number == 6;
            
            // the "do" makes sure that the switch statement will still run even if the user guesses the number on the first try
            do
            {
                switch (number)
                {
                    // if the user guesses the number 6
                    case 6:
                        // this will be printed in the terminal
                        Console.WriteLine("You guessed the correct number!");
                        // sets isSix to true
                        isSix = true;
                        // break ends the switch statement
                        break;
                    // default case is used when the number guessed is not 6
                    default:
                        Console.WriteLine("Wrong, try again");
                        Console.WriteLine("please enter a number between 0 and 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            // while the variable isSix is false it will run the above switch code in the do statement
            while (!isSix);

            Console.ReadLine();
        }
    }
}

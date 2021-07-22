// Following along with video instrcution from The Tech Academy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// var says that something is a variable; NOT THE TYPE
            //// C# is a statically typed language; state the datatype before declaring a variable
            //// This is a simple program
            //console.writeline("what is your name?");
            //// ReadLine() takes in the value
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your Name is: " + yourName);
            //Console.ReadLine();
            //Console.WriteLine("what is your favorite number?");
            //// Casting is the practice of action of changing one piece of data to another data type
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your Favorite Number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursworked = 42; // 0-255
            sbyte currentTemperature = -23; // like byte but allows negative numbers
            char questionMark = '\u2103'; // single quotes for single character 

            decimal moneyInBank = 10.5m; // m does not stand for million, needed when writing decimal; only used for finacial transaction

            double heightInCentimeters = 211.30202092; //15-16 digits in lenght can have decimal points

            float secondsLeft = 2.92f; // 7 digits in length; f for float

            short temperatureOnMars = -341; // -320000 - 320000

            string myName = "Ricky";

            // convert interger to a string
            int currentage = 30;
            string yearsOld = currentage.ToString();

            // convert boolean to string
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            
            // Best to avoid casting; design your program to avoid constantly having to convert values
            Console.WriteLine(rainingStatus);
            Console.ReadLine();



            
        }
    }
}

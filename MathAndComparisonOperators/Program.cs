using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("ten minus five = " + difference);
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int CurrentTemperature = 70;

            //bool isWarm = CurrentTemperature <= roomTemperature;
            //bool isWarm = CurrentTemperature == roomTemperature;
            //bool isWarm = CurrentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            // Console application assignment

            // multiply by 50
            Console.Write("please enter a number to be multiplied by 50: ");
            long num = Convert.ToInt64(Console.ReadLine());
            long multiply = num * 50;
            Console.WriteLine(multiply);
            Console.ReadLine();

            // add 25
            Console.Write("please enter a number to be added to 25 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add = num2 + 25;
            Console.WriteLine(add);
            Console.ReadLine();

            // divide 12.5
            Console.Write("please enter a number to be divided by 12.5: ");
            double num3 = Convert.ToDouble(Console.ReadLine()) / 12.5;
            Console.WriteLine(num3);
            Console.ReadLine();

            // true or false
            Console.Write("is your number greater than 50?: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan = num4 > 50;
            Console.WriteLine(greaterThan);
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite number?");
            int favoriteNum = Convert.ToInt32(Console.ReadLine());

            string result = favoriteNum == 12 ? "you have an awesome favorite number" : "you do not have a awesome favorite number";
            Console.WriteLine(result);

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hit, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temp");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("is it colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhh something went wrong");
            //}

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //// tenary operators
            //string comparisonResult = currentTemperature == roomTemperature ? "it is room temp." : "it is not room temp.";
            //Console.WriteLine(comparisonResult);

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temerperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temp is wamer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("it is not exactly room temperature");
            //}

            Console.ReadLine();
        }
    }
}

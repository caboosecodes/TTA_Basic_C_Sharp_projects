// Boolean Logic Submission Assignment from The Tech Academy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            // asks user's Age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // asks if the user has a DUI
            Console.WriteLine("Have you ever had a DUI, please enter \"true\" or \"false\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // asks the user how many tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // boolean logic using the user's answers to determine if they are qualified for car insurance
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets <=3);

            Console.ReadLine();
        }
    }
}

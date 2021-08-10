using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = false;
            int age = 0;

            while (!answer)
            {
                Console.WriteLine("Hello, how old are you?");
                answer = int.TryParse(Console.ReadLine(), out age);
                if (!answer) Console.WriteLine("Please use whole numbers only.");
            }
            
           
            int yearsToDays = age * 365;
            TimeSpan years = new TimeSpan(yearsToDays, 0, 0, 0);
            DateTime now = DateTime.Now;
            DateTime yearBorn = now.Subtract(years);
            Console.WriteLine("You were born in the year {0}", yearBorn.Year);
            Console.ReadLine();
        }
    }
}

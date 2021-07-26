using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            switch (day)
            {
                case 1:
                    Console.WriteLine("today is Monday");
                    break;
                case 2:
                    Console.WriteLine("today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("today is Friday");
                    break;
                case 6:
                    Console.WriteLine("today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("today is Sunday");
                    break;
            }
            Console.ReadLine();
        }
    }
}

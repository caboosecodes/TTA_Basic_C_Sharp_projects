using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for person 1's hourly rate and hours worked
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1:");
            Console.Write("Please enter Person 1's hourly rate: ");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter hours worked per week: ");
            int weekHours1 = Convert.ToInt32(Console.ReadLine());

            // Asks user for person 2's hourly rate and hours worked
            Console.WriteLine("Person 2:");
            Console.Write("Please enter Person 2's hourly rate: ");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter hours worked per week: ");
            int weekHours2 = Convert.ToInt32(Console.ReadLine());

            // Annual Salary for Person 1 and 2
            Console.WriteLine("Annual salay of Person 1:");
            int annualSalary1 = (hourlyRate1 * weekHours1) * 52;
            Console.WriteLine(annualSalary1);
            
            Console.WriteLine("Annual salay of Person 2:");
            int annualSalary2 = (hourlyRate2 * weekHours2) * 52;
            Console.WriteLine(annualSalary2);

            // Comparison between person 1 and person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = annualSalary1 > annualSalary2;
            Console.WriteLine(moreMoney);
            
            Console.ReadLine();

        }
    }
}

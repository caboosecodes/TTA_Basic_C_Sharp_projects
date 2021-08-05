using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// system.io is needed
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates an instance of DateTime as datetime and saves present datetime
            DateTime datetime = DateTime.Now;
            // prints datetime to console
            Console.WriteLine(datetime);
            // asks for user input
            Console.WriteLine("please input in a number");
            // saves user input as integer
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // initializes TimeSpan object with the userNumber as hours
            TimeSpan hours = new TimeSpan(0, userNumber, 0, 0);
            // adds hours to datetime
            DateTime hoursFromNow = datetime.Add(hours);
            // prints to the console
            Console.WriteLine("the time in {0} hours will be {1}", userNumber, hoursFromNow);
            

            Console.ReadLine();
            // writes it a file
            //File.WriteAllText(@"C:\Users\Ricar\Desktop\twentyoneIO\inputAssignmentLog.txt", text);
            //string file = File.ReadAllText(@"C:\Users\Ricar\Desktop\twentyoneIO\inputAssignmentLog.txt");
            //// reads the file
            //Console.WriteLine(file);
        }
    }
}

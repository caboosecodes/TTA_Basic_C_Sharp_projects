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
            DateTime datetime = DateTime.Now;
            Console.WriteLine(datetime);
            // asks for user input
            Console.WriteLine("please input in a number");
            // saves user input
            int userNumber = Convert.ToInt32(Console.ReadLine());

            TimeSpan hours = new TimeSpan(0, userNumber, 0, 0);

            DateTime hoursFromNow = datetime.Add(hours);
            
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

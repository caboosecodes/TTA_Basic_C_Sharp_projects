using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object initialization
            Employee worker = new Employee() { firstName = "Sample", lastName = "Student" };

            // calling on the inherited method
            worker.SayName();
            Console.ReadLine();
        }
    }
}

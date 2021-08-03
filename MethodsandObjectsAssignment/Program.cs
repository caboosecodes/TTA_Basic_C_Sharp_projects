using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // object initialization
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Calling on the superclass method SayName() that class Employee inherits from class Person
            employee.SayName();
            Console.ReadLine();
        }
    }
}

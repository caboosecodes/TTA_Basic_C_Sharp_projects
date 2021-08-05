using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant string variable
            const string UniName = "Generic University";
            // asks for user's name
            Console.WriteLine("Welcome to {0}\nPlease type in your name", UniName);
            // saves user input as a string
            string studentName = Console.ReadLine();
            // instantiates newStudent as an object in Student class and passes in studentName in the chained constructor
            // var to implicitly decide the datatype
            var newStudent = new Student(studentName);
            // writes out to the terminal with the student's name and id given to the student in the chained constructor 
            Console.WriteLine("Welcome, {0}, your ID is {1}, make sure to write it down!", newStudent.Name, newStudent.StudentId);


            Console.ReadLine();
        }
    }
}

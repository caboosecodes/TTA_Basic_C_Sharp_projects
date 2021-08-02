using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // instatiates Class1 with the variable method
            Class1 method = new Class1();
            // uses the class method SomeMethod and passes in the parameters 10 and 45
            method.SomeMethod(10, 45);

            Console.ReadLine();
        }
    }
}

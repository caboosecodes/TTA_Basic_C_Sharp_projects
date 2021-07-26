using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // and operator
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            // Or operator
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            // equal to operator
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            // not equal to
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            // xor operator will evalutates as true if only one is true but not both
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            // Conditional Statements Challenge
            //string name = "bob";
            //if (name == "ricky")
            //{
            //    Console.WriteLine("your name is ricky");
            //}
            //else
            //{
            //    Console.WriteLine("your name is not ricky");
            //}

            //string name2 = "ricky";
            //if (name2 != "ricky")
            //{
            //    Console.WriteLine("your name is not ricky");
            //}
            //else
            //{
            //    Console.WriteLine("your name is ricky");
            //}

            //int num = 45;
            //int num2 = 45;

            //if (num > num2)
            //{
            //    Console.WriteLine("number 1 is greater than number 2");
            //}
            //else if (num == num2)
            //{
            //    Console.WriteLine("number 1 to is equal to number 2");
            //}
            //else
            //{
            //    Console.WriteLine("number 1 is less to number 2");
            //}


            // Tenary operators
            int x = 10;
            int y = 15;
            string result = x < y ? "x is less than y" : "y is greater than x";
            Console.WriteLine(result);








            Console.ReadLine();
        }
    }
}

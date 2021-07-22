// Daily Report assignment from The Tech Academy

using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {   // Header
            Console.WriteLine("The Tech Academy\nStudent Daily Report:\n");

            // Asks for your name
            Console.WriteLine("What is your name?");
            // saves the response to the variable yourName
            string yourName = Console.ReadLine();
            // test code below to check if the variable was saved properly
            //Console.WriteLine("your name is " + yourName);
            
            // asks for course 
            Console.WriteLine("What course are you on?");
            // saves response to variable currentCourse
            string currentCourse = Console.ReadLine();

            // asks for page number
            Console.WriteLine("What page number? (whole numbers only please)");
            // saves the response to variable pageNumer
            string pageNumber = Console.ReadLine();
            // converts the string to integer
            int numberPage = Convert.ToInt32(pageNumber);
            // test code below
            //Console.WriteLine(numberPage);



            // asks if they need help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            // stores response in helpNeeded
            string helpNeeded = Console.ReadLine();
            // converts the string into a boolean
            bool bHelp = Convert.ToBoolean(helpNeeded);
            // test code below
            //Console.WriteLine(bHelp);


            // asks for positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            // stores response in positiveExperience as a string
            string positiveExperience = Console.ReadLine();


            // asks for feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            // stores response in feedback as a string
            string feedback = Console.ReadLine();


            // asks for how many hours studied
            Console.WriteLine("how many hours did you study today?");
            // stores response in studyHours
            string studyHours = Console.ReadLine();
            // converts string into a byte
            byte hoursStudied = Convert.ToByte(studyHours);
            // test code below
            //Console.WriteLine(hoursStudied);

            Console.WriteLine("Thank you for your answers. An instructor will repsond to this shortly. Have a great day!");


            
            Console.ReadLine();
        }
    }
}

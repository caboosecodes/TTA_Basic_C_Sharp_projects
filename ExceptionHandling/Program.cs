using System;


class Program
{
    static void Main(string[] args)
    {
        // exception handling are protections in the code that checks for particular errors and responds to those errors accordingly
        // what we want to do goes in the try block
        try 
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dividing the two.... ");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        // catching the FormatException and assinging it the variable "ex"
        // ex is a datatype for FormatException
        catch (FormatException ex)
        {
            Console.WriteLine("please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // finally runs no matter what
        finally
        {
            Console.ReadLine();
        }
        

        
    }
}

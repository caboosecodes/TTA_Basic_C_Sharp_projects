using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lists are more adaptable then Arrays
        // called generics
        // do not have to declare a length
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> intListS = new List<string>();
        intListS.Add("Hello");
        intListS.Add("Ricky");
        intListS.Remove("ricky");

        // Use an array when you have a fixed quantity that will not change

        //// an Array is a way to hold a group of variables
        //// to declare an Array you have to give a type of variable, square brackets[] and the name
        //// you have to create a new object of the array
        //// you have to define the length of the array before you begin
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// instead of writing multiple lines you can populate the array in one line
        //// arrays can not be resized dynamically
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //// another way to initialize an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //// can change the value a certain index
        //numArray2[5] = 650;

        // Lists are more adaptable then Arrays

        Console.WriteLine(intListS[0]);
        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Jesse");
        intList.Remove("Jesse");
        Console.WriteLine(intList[0]);

        byte[] byteArray = new byte[5000]; //can use arrays for small and fixed, or large quantities. Lists for all others

        //int[] numArray = new int[5]; //define how large the array is
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //this is the same as above, just easier
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 2300 }; //this is the easiest way to create an array

        //numArray2[5] = 650; //editing an existing array
        //Console.WriteLine(numArray2[5]);
        Console.ReadLine();
        }
    }

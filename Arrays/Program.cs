﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 1: Creating a double data type array
            //declares an array of type double with 10 elements
            double[] myArray = new double[10];

            //assigning the first element of the array
            myArray[0] = 1.0;

            //assigning the second element of the array
            myArray[1] = 1.1;

            //assigning the third element of the array
            myArray[2] = 1.2;

            //assigning the fourth element of the array
            myArray[3] = 1.3;

            //assigning the fifth element of the array
            myArray[4] = 1.4;

            //assigning the sixth element of the array
            myArray[5] = 1.5;

            //assigning the seventh element of the array
            myArray[6] = 1.6;

            //assigning the eight element of the array
            myArray[7] = 1.7;

            //assigning the ninth element of the array
            myArray[8] = 1.8;

            //assigning the tenth element of the array
            myArray[9] = 1.9;

            //STEP 2: Print the elements of the array in the console
            //Printing out each elements of the array
            Console.WriteLine("The element at index 0 in the array is " + myArray[0]);
            Console.WriteLine("The element at index 1 in the array is " + myArray[1]);
            Console.WriteLine("The element at index 2 in the array is " + myArray[2]);
            Console.WriteLine("The element at index 3 in the array is " + myArray[3]);
            Console.WriteLine("The element at index 4 in the array is " + myArray[4]);
            Console.WriteLine("The element at index 5 in the array is " + myArray[5]);
            Console.WriteLine("The element at index 6 in the array is " + myArray[6]);
            Console.WriteLine("The element at index 7 in the array is " + myArray[7]);
            Console.WriteLine("The element at index 8 in the array is " + myArray[8]);
            Console.WriteLine("The element at index 9 in the array is " + myArray[9]);

            //Attempt to assign a value to index 10
            //myArray[10] = 1.10;
        }
    }
}

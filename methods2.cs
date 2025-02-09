using System;

namespace methods2
{
    class Program
    {
        static void multiplier(string[] args)
        {
            int result = Multiply(3, 7); //sets int result equal to whats returned from the function

            Console.WriteLine($"The result is {result}");

            //check if result is even/uneven

            if(result % 2 == 0) // % checks the remainder if divided by two
            {
                Console.WriteLine($"{result} is an even number!");
            }
            else
            {
                Console.Write($"{result} is an uneven number!");
            }

            //wait before closing
            Console.ReadKey();
        }

        //void returns nothing to where its called from, if you want it to return a parameter put the type you want to return instead of void (e.g int)

        static int Multiply(int num01, int num02) //typeofVariable function_name(parameters), parameters can be entered when calling the method
        {
            int result = num01 * num02;         //variables are only stored inside of the function
            return result; //return WhatGetsReturned;
        }
    }
}
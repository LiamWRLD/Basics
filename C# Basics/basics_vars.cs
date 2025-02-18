using System;
using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;
using conditions;

namespace basics_vars
{
    class Program
    {
        static void Dialogue(string[] args)
        {
            //Set the Look of the Console

            Console.Title = "TextBox";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WindowHeight =  30;

            //First Conversation

            Console.WriteLine("Hello, What's your name?");

            string userName = Console.ReadLine(); //Set the name to the users input

            Console.WriteLine($"Hello {userName}!\nMy name is Fayber!\nI'm a blonde Person :("); // $ symbol works like f in python
            Console.WriteLine("What is your favorite color?");

            string favColor = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue; //Change the text color
            Console.WriteLine($"{favColor} is a cool color!");

            //Declare variables

            double num01; //double = float but with more decimal places
            double num02;
            double num03;

            Console.Write("Enter a number: "); // Written and Input in one Line
            num01 = Convert.ToDouble(Console.ReadLine()); //Convert input to a double and set num01 to the double

            Console.Write("Enter a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            double result = num01 * num02;
            Console.WriteLine($"The result is {result}!");

            //Calculate average = (x + y + z) / 3

            Console.Write("Enter a third number: ");
            num03 = Convert.ToDouble(Console.ReadLine());

            double average = (num01 + num02 + num03) / 3;
            Console.WriteLine($"The average of your numbers is {average}");

            //wait before closing
            Console.ReadKey();
        }
    }
}

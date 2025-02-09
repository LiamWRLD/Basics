using System;
using System.ComponentModel;
using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;

namespace conditions
{
    public class Program //Making the class public for other scripts
    {
        public static void Tax_control(string[] args) //Making method public
        {
            //Tax pay

            Console.WriteLine("Welcome! Pay 5$ taxes! Insert Cash please");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("Not Enough!");
                Console.ReadKey();
                return;
            }
            else if (cash == 5)
            {
                Console.WriteLine("You paid taxes!");
            }
            else
            {
                int change = cash - 5; //the change is the money paid minus the price
                Console.WriteLine($"You paid taxes and got {change}$ change!");
            }

            //Control

            Console.WriteLine("You can now continue to the control.");

            int age;
            int height;

            Console.Write("Input your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if(age >= 18 && height >= 165) //greater than or equal, && = and, || = or
            {
                Console.WriteLine("You're good to go!");
            }
            else
            {
                Console.WriteLine("You cant go further!");
                Console.ReadKey();
                return;
            }

            //Math Test
            Console.Write("4 + 6 * 2 = ");
            int user_answer = Convert.ToInt32(Console.ReadLine());

            if(user_answer == 16) //double equal so it doesnt set it but check it
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
                Console.ReadKey();
                return;
            }

            Console.Write("Input a number between 1 and 5: ");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num) //in cases with one variable but many options the switch function can check it easier and more overseeable
            {
                case 1: //basically if the variable = 1
                    Console.WriteLine("One");
                    break; //stops the switch
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default: //will happen if no other case is true
                    Console.WriteLine("Default");
                    break;

            }

            //Wait before Closing
            Console.ReadKey();
        }
    }
}
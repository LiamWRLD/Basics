using System;

namespace methods1
{
    class Program
    {
        static void SpeedDating(string[] args)
        {
            MeetAlien(); //calls the new function if also defined in the same file

            Console.WriteLine("-------------");

            MeetAlien();

            //Wait before closing
            Console.ReadKey();
        }

        static void MeetAlien() //void defines a new function/method
        {
            Random numberGen = new Random(); //if confused look at 'loops' file

            string name = "X-" + numberGen.Next(10, 9999); // + is an alternative use for $
            int age = numberGen.Next(10, 500);

            Console.WriteLine($"Hi, I'm {name}!");
            Console.WriteLine($"I'm {age} years old!");
            Console.WriteLine("And I'm an alien!");
        }
    }
}

using System;

namespace loops
{
    public class Program
    {
        static void Counter(string[] args)
        {
            //Count to 10

            for (int i = 1; i < 10; i++) // (before the loop; condition for the loop to keep going; result after the loop)
            {
                Console.WriteLine(i); //writes i 10 times because of the ten in the for loop and I goes up by 1 each time the loop is restarted
                //everything in the loop will be repeated
            }
            
            Console.WriteLine("Counted up to 10! "); //place finish messages outside of loop!
            Console.ReadLine();

            //starting at 10 and counting down

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Counted down to 10!");
            Console.ReadLine();

            //Counting up with calculation

            Console.Write("How many numbers you want?: ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++) // <= is smaller or equal to, repeats the loop as many times as the player inputs
            {
                double result = Math.Pow(2, i); //Math function has many useful mathematics. (number to be raised by a power, what power to raise it by)
                Console.WriteLine(result);
            }

            //Roll dice until wish number is rolled

            Random numberGen = new Random(); //creates a random generator

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice!");

            while (roll != 6) // != is not equal
            {
                Console.ReadKey(); //makes it so you have to press enter each time you roll
                roll = numberGen.Next(1, 7); // (min, max) min is included, max is excluded from possible output, this example chooses from 1 to 6
                Console.WriteLine($"You rolled: {roll}");
                attempts++; //increases variable by 1
            }

            Console.WriteLine($"it took you {attempts} to roll a 6!");

            //Wait before closing
            Console.ReadKey();
        }
    }
}

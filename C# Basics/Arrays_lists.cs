using System;
using System.Collections.Generic; //makes lists usable
using System.Runtime.InteropServices;

namespace Arrays_lists
{
    class Program
    {
        static void MovieList(string[] args)
        {
            //create and declare an array of strings if content is known

            string[] movies1 = {"Star Wars 3", "500 Days of Summer", "Avengers Endgame", "Lord of the Rings"};
            Console.WriteLine("Here are four movies: ");

            //print out each item on its own
            for (int i = 0; i < movies1.Length; i++) //.length always uses the total number of items in the list
            {
                int rank = i + 1;
                Console.WriteLine($"{rank}. {movies1[i]}"); // list_name[index], index = according number of the item in the list
            }


            //create an array when content is unknown, but length of array is known.

            string[] movies2 = new string[4]; //new string [length];

            Console.WriteLine("\nNow type in four movies: "); //the \n is to put an empty line before, makes it look cleaner

            for (int i = 0; i < movies2.Length; i++)
            {
                movies2[i] = Console.ReadLine(); //assignes the players input into the according index of the list
            }

            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(movies2); //automatically sorts them alphabetically

            for (int i = 0; i < movies2.Length; i++)
            {
                Console.WriteLine(movies2[i]);
            }

            Console.ReadLine();

            //create a list when content and length is unknown
            //arrays require you to put the length when the array is created, lists adjust themselves automatically
            
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Sugar"); //adds an item to a list
            shoppingList.Add("Eggs");
            shoppingList.Add("Cheese");
            shoppingList.Add("Tomatoes");

            Console.WriteLine("Dont forget to buy these: "); // \n not necessary because of the Console.Readline before

            for (int i = 0; i < shoppingList.Count; i++) //.Length doesnt work with list, instead use .Count
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Eggs"); //removes entry from list using the name
            shoppingList.RemoveAt(1); //removes entry from list using the index

            //be careful, the remove at uses the new index after the other item is already deleted

            Console.WriteLine("-------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            //Wait before closing
            Console.ReadKey();
        }
    }
}

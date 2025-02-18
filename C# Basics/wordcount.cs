using System;

namespace numbercount
{
    class Program
    {
        static void countWords(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int wordCount = countWords(sentence);
            Console.WriteLine($"There are {wordCount} words in your sentence!");

            //wait before closing
            Console.ReadKey();
        }

        static int countWords(string sentence)
        {
            int wordCount = sentence.Split(' ').Length; //splits the sentence everytime there is a space and puts the individual parts/words into an array
            return wordCount;
        }
    }
}

using System;

namespace studenname_list
{
    class Program
    {
        static void studentList(string[] args)
        {
            Console.WriteLine("How many students are in the class: ");
            int students = Convert.ToInt32(Console.ReadLine());
            string[] studentNames = new string[students];
            Console.WriteLine("Input the name of the students: ");

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = Console.ReadLine();              
            }

            Console.WriteLine("\nHere is your list of students alphabetically: ");
            Array.Sort(studentNames);

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine(studentNames[i]);
            }

            Console.ReadKey();
        }
    }
}

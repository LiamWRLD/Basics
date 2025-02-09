using System;

namespace classes
{
    class Wizard //additional class
    {
        //declare variables/properties in the class, accessable for all methods inside the class
        public string name;
        public string favoriteSpell; //public = public access from all other classes and methods, by using classname.variablename/classname.methodname
        private int spellSlots; //private = access only from inside the class, if private variable is declared in private method it's only accessable in that method
        private float experience; //if no private or public is written, it defaults to private

        public static int Count; //static variable means that the variable is the same for every instance made of the class, non-static variables are unique to their instance when created

        public Wizard(string _name, string _favoriteSpell) //creates a constructor, not a method because return value assignment isn't there
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f; //f = float

            Count++; //increases Count by 1
        }

        public void CastSpell()
        {
            if(spellSlots > 0)
            {
                Console.WriteLine($"{name} casts {favoriteSpell}!");
                spellSlots -= 1; //decreases the spellSlots by one
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine($"{name} is out of spell slots!");
            }
        }
        
        public void Meditate()
        {
            Console.WriteLine($"{name} meditates to regain spell slots...");
            spellSlots = 2;
        }
    }

    class Program //main class
    {
        static void Main(string[] args) //static tag for method means that the method can be accessed using classname.methodname easily
        {
            Wizard wizard01 = new Wizard("Harry Potter", "Expecto Patronum"); //access the class to create a new instance/copy of the class


            //wizard01.name = "Harry Potter"; //could be used to access the variable of the instance we created before, in this example name is set in parameter

            wizard01.CastSpell(); //calls the method from the instance
            wizard01.CastSpell();
            wizard01.CastSpell();

            wizard01.Meditate();

            wizard01.CastSpell();

            Console.WriteLine("------------"); //here to seperate wizard 1 from wizard 2

            Wizard wizard02 = new Wizard("Ron Weasley", "Wingardium Leviosa");

            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count); //due to static tag we access the variable in the real class and not the variable of a specific instance, Wizard.Count instead of e.g wizard01.Count


            //wait before closing
            Console.ReadKey();
        }
    }
}
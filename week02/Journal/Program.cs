using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. display");
            Console.WriteLine("3. save");
            Console.WriteLine("4. load");
            Console.WriteLine("5. quit");

            Console.Write("enter selection: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Write new entry");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Display Journal");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Save Journal");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Load Journal");
            }
            else if (userInput == "5")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();

        Console.Write("Enter your username: ");
        string userName = Console.ReadLine();

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
                journal.CreateNewEntry();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Displaying Journals");
                journal.DisplayEntries();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Saving Journal...");
                journal.SaveToFile(userName);
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
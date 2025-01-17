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
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");

            Console.Write("Enter selection: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                journal.CreateNewEntry();
            }
            else if (userInput == "2")
            {
                journal.DisplayEntries();
            }
            else if (userInput == "3")
            {
                journal.SaveToFile(userName);
            }
            else if (userInput == "4")
            {
                journal.LoadFromFile();
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
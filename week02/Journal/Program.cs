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

            Console.Write("enter seelction: ");
            string userInput = Console.ReadLine();

            Console.WriteLine($"user selected {userInput}");
        }
    }

}
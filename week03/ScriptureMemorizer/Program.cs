using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "I will go and do the things the Lord commands.");

        Console.WriteLine(scripture.GetDisplayText());




        //loop 
        // display, hide, check if need to quit
        // Use the functions in the scripture class.


    }
}
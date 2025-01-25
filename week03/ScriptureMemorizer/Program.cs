using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Word w = new Word("truth");
        Console.WriteLine(w.GetDisplayText());

        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "I will go and do....");

        Console.WriteLine(reference.GetDisplayText());
        //loop 
        // display, hide, check if need to quit
        // Use the functions in the scripture class.
    }
}
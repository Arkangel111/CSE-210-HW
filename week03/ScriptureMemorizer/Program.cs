using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Word w = new Word("truth");
        Console.WriteLine("Test: " + w.GetDisplayText());

        w.Hide();
        Console.WriteLine("Test Hide: " + w.GetDisplayText());

        w.Show();
        Console.WriteLine("Testing all hidden: " + w.GetDisplayText());

        Reference reference = new Reference("1 Nephi", 3, 7, 9);
        Scripture scripture = new Scripture(reference, "Faith.");

        Console.WriteLine("Shown:");
        Console.WriteLine(scripture.GetDisplayText());

        scripture.HideRandomWords();

        Console.WriteLine("Hidden:");
        Console.WriteLine(scripture.GetDisplayText());




        //loop 
        // display, hide, check if need to quit
        // Use the functions in the scripture class.


    }
}
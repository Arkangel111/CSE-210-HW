using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Hardcoded Scriptures
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son"),
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heavens and the earth"),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want")
        };

        // Display scriptures
        foreach (var scripture in scriptures)
        {
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}
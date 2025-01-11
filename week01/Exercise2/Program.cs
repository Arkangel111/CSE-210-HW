using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade was a(n) {letterGrade}");
        {
            if (grade < 70)
            {
                Console.WriteLine("You have failed the class.");
            }
            else
            {
                Console.WriteLine("CONGRATULATIONS! You passed the course.");
            }
        }
    }
}
using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you cn use it in other aspects of your life.", 0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."

        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"=== {prompt} ===");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder  on each of the following questions as they relate to this experience.");
        ShowCountDown(5, "You may begin in: ");
        foreach (string question in _questions)
        {
            Console.WriteLine();
            Console.WriteLine(question);
            ShowSpinner(10);
        }

        Console.WriteLine();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"=== {GetRandomPrompt()} ===");
        }
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine($"-= {question} =-");
        }
    }
}

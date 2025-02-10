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
        DisplayStartingMessage();
        int duration = GetDuration(); // used AI for this, I got stuck in an infinite loop when prompting for duration
        DateTime endTime = DateTime.Now.AddSeconds(duration + 15);

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"=== {prompt} ===");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder  on each of the following questions as they relate to this experience. (press enter for new question)");

        ShowCountDown(5, "You may begin in: ");

        // the following lines of code were with help of AI, I ran into an infinite loop here and had to find out where I went wrong
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine();
            Console.WriteLine(question);
            Console.ReadLine();

            if (DateTime.Now >= endTime)
                break;
        // end AI help section
        }

        // foreach (string question in _questions)
        // {
        //     Console.WriteLine();
        //     Console.WriteLine(question);
        //     ShowSpinner(10);
        // }

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(8);
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

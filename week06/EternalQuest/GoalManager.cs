using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.Write($"\nYou have {_score} points.");
    }


    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal?");
        string _shortName = Console.ReadLine();

        Console.Write("What is a short description of your goal?");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(_shortName, description, points);
                break;

            case "2":
                newGoal = new EternalGoal(_shortName, description, points);
                break;

            case "3":
                Console.Write("How many times does the goal need to be accomplished for the bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for completing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(_shortName, description, points, target, bonus);
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }
        _goals.Add(newGoal);
        Console.WriteLine($"Goal Added: {newGoal.GetStringRepresentation()}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour goals are:");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
            index++;
        }
        Console.ReadLine();
    }
    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;
        Goal selectedGoal = _goals[choice];
        selectedGoal.RecordEvent();

        _score += selectedGoal._points;

        if (selectedGoal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus;
                Console.WriteLine($"You have completed the checklist goal {checklistGoal._shortName} and earned a bonus of {checklistGoal.Bonus} points.");
            }
        }
        Console.WriteLine($"You earned {selectedGoal._points} points for that goal.");
        Console.WriteLine($"You have {_score} points now.");
    }

    public void SaveGoals()
    {
        string fileName = "goals.txt";

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goal saved!!");
        Console.Beep();
        Console.ReadLine();
    }


    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");
        if (lines.Length > 0 && int.TryParse(lines[0], out int savedScore))
        {
            _score = savedScore;
        }
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            if (parts.Length > 0)
            {
                switch (parts[0])
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[4]);
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), isComplete));
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;

                    case "ChecklistGoal":
                        int _targetCount = int.Parse(parts[4]);
                        int _bonus = int.Parse(parts[5]);
                        int _amountCompleted = int.Parse(parts[6]);
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), _targetCount, _bonus, _amountCompleted));
                        break;
                }
                ;
            }
        }
        Console.WriteLine("Goals loaded Successfully!");
        Console.ReadLine();
    }

}
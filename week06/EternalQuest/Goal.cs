using System;

public abstract class Goal
{
    public string _shortName { get; }
    public string _description { get; }
    public int _points { get; }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        // bool complete = IsComplete();
        // Console.WriteLine($"Debug: Goal {_shortName} IsComplete = {complete}");
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description} ({_points} points)";
    }
    public abstract string GetStringRepresentation();

}
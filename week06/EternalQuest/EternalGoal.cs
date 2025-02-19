using System;
using System.Runtime.CompilerServices;

public class EternalGoal : Goal
{
    private bool _isComplete;
    private int _totalPoints;

    int timesCompleted = 0;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
        _totalPoints = 0;
    }

    public override void RecordEvent()
    {
        _totalPoints += _points;
        timesCompleted++;
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{timesCompleted}";
    }
}

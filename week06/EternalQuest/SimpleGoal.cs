using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        return;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
using System;

public class EternalGoal(string name, string description, string points)
{
    _shortName = name;
    _description = description;
    _points = points;

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

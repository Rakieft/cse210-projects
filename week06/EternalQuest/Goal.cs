using System;

// Base class for all goals
public abstract class Goal
{
    protected string _name;
    protected string _description;

    public string ShortName => _name;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract void Display();
    public abstract int RecordEvent();
    public abstract string GetSaveString();
}
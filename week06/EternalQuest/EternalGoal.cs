// Eternal goal that can be repeated infinitely
public class EternalGoal : Goal
{
    private int _points;

    public EternalGoal(string name, string description, int points)
        : base(name, description)
    {
        _points = points;
    }

    public override void Display()
    {
        Console.WriteLine($"[∞] {_name} ({_description})");
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}
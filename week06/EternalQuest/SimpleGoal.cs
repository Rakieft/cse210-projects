// Simple goal that is completed once
public class SimpleGoal : Goal
{
    private int _points;       
    private bool _isComplete;  

    // Constructor to initialize the simple goal
    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description) // Call the base class constructor to set name and description
    {
        _points = points;
        _isComplete = isComplete;
    }

    // Display the goal with its status (completed or not)
    public override void Display()
    {
        string status = _isComplete ? "[X]" : "[ ]"; 
        Console.WriteLine($"{status} {_name} ({_description})");
    }

    // Record an event (i.e., mark the goal as complete) and return points if not already completed
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points; 
        }
        return 0; 
    }

    // Create a string format to save this goal to a file
    public override string GetSaveString()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }
}

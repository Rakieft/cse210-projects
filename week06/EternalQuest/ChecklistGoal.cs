// Checklist goal that needs to be completed a specific number of times
public class ChecklistGoal : Goal
{
    private int _points;      
    private int _bonus;      
    private int _targetCount;   
    private int _currentCount; 

    // Constructor to initialize the checklist goal
    public ChecklistGoal(string name, string description, int points, int bonus, int targetCount, int currentCount = 0)
        : base(name, description) 
    {
        _points = points;
        _bonus = bonus;
        _targetCount = targetCount;
        _currentCount = currentCount;
    }

    // Display the goal with its status and progress
    public override void Display()
    {
        string status = _currentCount >= _targetCount ? "[X]" : "[ ]"; 
        Console.WriteLine($"{status} {_name} ({_description}) — Completed {_currentCount}/{_targetCount} times");
    }

    // Record progress on the goal and return points
    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                // If final completion, return both normal points and bonus
                return _points + _bonus;
            }
            return _points; 
        }
        return 0; 
    }

    // Create a string to save this goal's data to a file
    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
    }
}
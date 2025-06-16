public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Default constructor (for new goals)
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Overloaded constructor (for loading from file)
    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
        => $"[{(_isComplete ? "X" : " ")}] {GetName()} ({GetDescription()})";

    public override string GetSaveData()
        => $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
}



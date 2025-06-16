public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
        _isComplete = false;
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

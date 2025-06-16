public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _count;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int count = 0)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override int RecordEvent()
    {
        if (_count < _target)
        {
            _count++;
            int total = GetPoints();
            if (_count == _target)
                total += _bonus;
            return total;
        }
        return 0;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetStatus()
        => $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Completed {_count}/{_target}";

    public override string GetSaveData()
        => $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_count}";
}

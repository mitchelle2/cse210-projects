public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent() => GetPoints();
    public override bool IsComplete() => false;

    public override string GetStatus()
        => $"[∞] {GetName()} ({GetDescription()})";

    public override string GetSaveData()
        => $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
}

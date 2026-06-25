public class Checklist : Goal
{
    private int _goalNumber;
    private int _currentNumber;
    private int _bonusPoint;

    public Checklist(string name, string description, int point, int goalNum, int bonus):base(name, description, point)
    {
        SetName(name);
        SetDescription(description);
        SetPoint(point);
        _goalNumber = goalNum;
        _currentNumber = 0;
        _bonusPoint = bonus;
    }
    public void SetGoalNum(int goalNum)
    {
        _goalNumber = goalNum;
    }
    public void SetCurrentNum(int currNum)
    {
        _currentNumber = currNum;
    }
    public void SetBonus(int bonus)
    {
        _bonusPoint = bonus;
    }
    public int GetGoalNum()
    {
        return _goalNumber;
    }
    public int GetCurrentNum()
    {
        return _currentNumber;
    }
    public int GetBonus()
    {
        return _bonusPoint;
    }
}
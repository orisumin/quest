public class Goal
{
    private string _name;
    private string _description;
    private int _point;

    public Goal(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _point = point;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetPoint(int point)
    {
        _point = point;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoint()
    {
        return _point;
    }
}
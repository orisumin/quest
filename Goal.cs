public class Goal:Program
{   protected string jb_name = "";
    protected string jb_description = "";
    protected string jb_point = "";    
    protected string SetName(string jb_name)
    {return jb_name;}
    protected string SetDescription(string jb_description)
    {return jb_description;}
    protected int SetPoint(int jb_point)
    {return jb_point;}
    
    
    
    
    
    
    
    public void savefile()
    {
        string fileName = "goaltracker.txt";

        using (StreamWriter outputFile = new StreamWriter ("goaltracker.txt"))
        {
            outputFile.WriteLine("Example.");
            
        }
    }
    
    public void ReadFile()
    {
        string fileName = "goaltracker.txt";
        string[] lines = System.IO.File.ReadAllLines("goaltracker.txt");

        foreach (string line in lines)
        Console.Write(line);
    }
    

    
}

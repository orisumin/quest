public class Goal:Program
{   protected string jb_name = protected string jbName;
    protected string jb_description = protected string jbDescription;
    protected string jb_point = protected int Point;    
    
    
    
    
    
    
    
    
    
    
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

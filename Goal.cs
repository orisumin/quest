public class Goal
{public void savefile()
    {
        string fileName = "goaltracker.txt";

        using (StreamWriter outputFile = new StreamWriter ("goaltracker.txt"))
        {
            outputFile.WriteLine("Example.");
            
        }
    }
    

}
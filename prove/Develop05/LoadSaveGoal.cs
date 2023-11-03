using System;
using System.IO;
using System.Collections.Generic;

/* Load and Save Goal class */
public class LoadSaveGoal
{
    private string _fileName;

    public LoadSaveGoal(string fileName)
    {
        _fileName = fileName;
    }

    public void SaveGoal(string fileName, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        };
        string firstPath = "./prove/Develop05/";
        string filePath = Path.Combine(firstPath, fileName);
    }
    
    public static LoadSaveGoal RetrieveGoal(string line)
    {
        string [] parts = line.Split('~');
        if (parts[0] == "Simple Goal")
        {
            SimpleGoal sGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
            return sGoal;
        }
        else if (parts[0] == "Eternal Goal")
        {
            EternalGoal eGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
            return eGoal;
        }
        else if (parts[0] == "Checklist Goal")
        {
            ChecklistGoal cGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
            return cGoal;
        }
        else
        {
            return null;
        }
    }

}

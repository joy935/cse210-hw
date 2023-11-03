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


}

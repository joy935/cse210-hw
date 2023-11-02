using System;
using System.IO;
using System.Collections.Generic;

/* Load and Save Goal derived class */
public class LoadSaveGoal
{
    private string _fileName;
    private List<SimpleGoal> _goals = new List<SimpleGoal>();

    public LoadSaveGoal(string fileName)
    {
        _fileName = fileName;
    }

    public void SaveGoal(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (SimpleGoal goal in _goals)
            {
                outputFile.WriteLine(goal.DisplayGoal());
            }
        }
    }

    public string SaveFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string firstPath = "./prove/Develop05/";
        string filePath = Path.Combine(firstPath, filename);
        string goalsText = string.Join("\n", _goals);
        System.IO.File.WriteAllText(filePath, goalsText);
        return _fileName;
    }

}

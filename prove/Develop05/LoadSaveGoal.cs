using System;
using System.IO;
using System.Collections.Generic;

/* Load and Save Goal derived class */
public class LoadSaveGoal : Goal
{
    private string _fileName;
    private List<SimpleGoal> _goals = new List<SimpleGoal>();

    public LoadSaveGoal(string name, string description, int points, string fileName) : base(name, description, points)
    {
        _fileName = fileName;
    }

    public override string CreateGoal()
    {
        return "Load and Save Goal";
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
        string firstPath = "./";
        string filePath = Path.Combine(firstPath, filename);
        string goalsText = string.Join("\n", _goals);
        System.IO.File.WriteAllText(filePath, goalsText);
        return _fileName;
    }

}

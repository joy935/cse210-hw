using System;
using System.IO;
using System.Collections.Generic;

/* Load and Save Goal derived class */
public class LoadSaveGoal : Goal
{
    private string _fileName;

    public LoadSaveGoal(string name, string description, int points, string fileName) : base(name, description, points)
    {
        _fileName = fileName;
    }

    public override string CreateGoal()
    {
        return "Load and Save Goal";
    }

    public override string DisplayGoal()
    {
        return "Load and Save Goal";
    }

    public void SaveGoal(string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (SimpleGoal goal in goals)
            {
                string line = goal.DisplayGoal();
                outputFile.WriteLine(line);
            }
        }
    }

}

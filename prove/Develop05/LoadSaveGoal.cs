using System;
using System.IO;
using System.Collections.Generic;

/* Load and Save Goal class */
public class LoadSaveGoal
{
    private string _fileName;
    private int _totalPoints;

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public LoadSaveGoal(string fileName)
    {
        _fileName = fileName;
    }

    public void SaveGoal(string fileName, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"TotalPoints: {_totalPoints}");
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        };
        string firstPath = "./prove/Develop05/";
        string filePath = Path.Combine(firstPath, fileName);
    }

    public List<Goal> LoadGoal(string fileName)
    {
        
        List<Goal> goals = new List<Goal>();
        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string [] parts = line.Split(':');
            string type = parts[0];
            string details = parts[1];
            
            if (type == "TotalPoints")
            {
                _totalPoints = int.Parse(details);
            }
            else 
            {
                string [] infos = details.Split('~');
                string name = infos[0];
                string description = infos[1];
                int points = int.Parse(infos[2]);

                if (type == "SimpleGoal")
                {
                    bool completed = bool.Parse(infos[3]);

                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, completed);
                    sGoal.GetStringRepresentation();
                    goals.Add(sGoal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points);
                    eGoal.GetStringRepresentation();
                    goals.Add(eGoal);
                }
                else if (type == "ChecklistGoal")
                {
                    int bonus = int.Parse(infos[3]);
                    int totalRepetition = int.Parse(infos[4]);
                    int numberRepetition = int.Parse(infos[5]);  

                    ChecklistGoal cGoal = new ChecklistGoal(type, name, description, points, bonus, totalRepetition, numberRepetition);
                    cGoal.GetStringRepresentation();
                    goals.Add(cGoal);
                }
                else
                {
                    Console.WriteLine("Invalid type. Please try again.");
                }
            }

        }
        return goals;
    }
}

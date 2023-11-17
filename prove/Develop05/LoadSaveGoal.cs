using System;
using System.IO;
using System.Collections.Generic;

/* Load and Save Goal class */
public class LoadSaveGoal
{
    // attributes of the class
    private string _fileName; // the name of the file
    private int _totalPoints; // the total points of the goals

    /* Getter and setter for the _totalPoints attribute of the class */
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    /* LoadSaveGoal is a constructor method that creates an instance of the LoadSaveGoal class.
    Parameters: string fileName
    Return: none
    */
    public LoadSaveGoal(string fileName)
    {
        _fileName = fileName;
    }

    /* SaveGoal is a method to save the goals to a file.
    Parameters: 
    fileName, the name of the file
    goals - a list of goals
    Return: none
    */
    public void SaveGoal(string fileName, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"TotalPoints:{_totalPoints}");      // write the total points to the file
            foreach (Goal goal in goals)                              // write each goal to the file
            {
                outputFile.WriteLine(goal.GetStringRepresentation()); // write the string representation of the goal to the file
            }
        };
        string firstPath = "./prove/Develop05/";
        string filePath = Path.Combine(firstPath, fileName);
    }

    /* LoadGoal is a method to load the goals from a file. 
    Parameters: fileName - the name of the file
    Return: a list of goals
    */
    public List<Goal> LoadGoal(string fileName)
    {
        
        List<Goal> goals = new List<Goal>(); // create a list of goals
        string [] lines = System.IO.File.ReadAllLines(fileName); 

        // loop through the lines of the file
        foreach (string line in lines)
        {
            string [] parts = line.Split(':');  // split the line into parts
            
            string type = parts[0];             // get the type of the goal
            string details = parts[1];          // get the details of the goal
            
            // if the type is TotalPoints
            if (type == "TotalPoints")
            {
                _totalPoints = int.Parse(details);  // set the total points
                SetTotalPoints(_totalPoints);       // set the total points in the file
            }
            // if the type is SimpleGoal, EternalGoal, or ChecklistGoal
            else 
            {
                string [] infos = details.Split('~');   // split the details into parts
                string name = infos[0];                 // get the name of the goal
                string description = infos[1];          // get the description of the goal
                int points = int.Parse(infos[2]);       // get the points of the goal

                // if the type is SimpleGoal
                if (type == "SimpleGoal")
                {
                    // get the completed status of the goal
                    bool completed = bool.Parse(infos[3]);
                    // create a new SimpleGoal object
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, completed);
                    // call the GetStringRepresentation method
                    sGoal.GetStringRepresentation();
                    // add the goal to the list of goals
                    goals.Add(sGoal);
                }
                // if the type is EternalGoal
                else if (type == "EternalGoal")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points);
                    eGoal.GetStringRepresentation();
                    goals.Add(eGoal);
                }
                // if the type is ChecklistGoal
                else if (type == "ChecklistGoal")
                {
                    int bonus = int.Parse(infos[3]);            // get the bonus of the goal
                    int totalRepetition = int.Parse(infos[4]);  // get the total repetition of the goal
                    int numberRepetition = int.Parse(infos[5]); // get the number repetition of the goal

                    ChecklistGoal cGoal = new ChecklistGoal(type, name, description, points, bonus, totalRepetition, numberRepetition);
                    cGoal.GetStringRepresentation();
                    goals.Add(cGoal);
                }
                // if the type is invalid
                else
                {
                    Console.WriteLine("Invalid type. Please try again.");
                }
            }

        }
        return goals;
    }
}

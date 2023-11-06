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

    public void LoadGoal()
    {
        // read in the line
        // split it based on the colon : to get the type of the object (Person) and the details ("Brigham,Young")
        //create a method called CreateGoal that would accept the string of details ("Brigham,Young"). This method could split the string on the commas to get the various items. Then, it could create a new Person object, set all the values, and return it.
    }
}

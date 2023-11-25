using System;

/* FileHandler Class */
public class FileHandler
{
    /* attributes of the class */
    private string _fileName;    // name of the file
    private List<Task> _tasks;   // list of tasks

    /* constructor of the class */
    public FileHandler(string fileName, List<Task> tasks)
    {
        _fileName = fileName;
        _tasks = tasks;
    }

    /* Getters and setters for the attributes of the class */
    public string GetFileName()
    {
        return _fileName;
    }
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    public List<Task> GetTasks()
    {
        return _tasks;
    }
    public void SetTasks(List<Task> tasks)
    {
        _tasks = tasks;
    }

    /* SaveToFile ...
    */
    public void SaveToFile(string fileName, List<Task> tasks)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Task task in tasks)
            {
                outputFile.WriteLine(task.GetTaskInfo());
            }
        };
        string firstPath = "./final/FinalProject/";
        string filePath = Path.Combine(firstPath, fileName);
    }
}
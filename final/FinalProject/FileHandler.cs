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

    public List<Task> LoadFromFile(string fileName)
    {
        List<Task> tasks = new List<Task>();
        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string [] parts = line.Split(":");

            string taskType = parts[0];
            string taskDetails = parts[1];

            string [] infos = taskDetails.Split("~");
            string taskDescription = infos[0];

            if (taskType == "SimpleTask")
            {
                bool isCompleted = bool.Parse(infos[1]);
                SimpleTask simpleTask = new SimpleTask("SimpleTask", taskDescription, isCompleted);
                tasks.Add(simpleTask);
            }
            else if (taskType == "ScheduledTask")
            {
                DateTime dueDate = Convert.ToDateTime(infos[1]);
                bool isCompleted = bool.Parse(infos[2]);
                ScheduledTask scheduledTask = new ScheduledTask("ScheduledTask", taskDescription, isCompleted, dueDate);
                tasks.Add(scheduledTask);
            }
            else if (taskType == "RepetitiveTask")
            {
                DateTime dueDate = Convert.ToDateTime(infos[1]);
                string frequencyRepetition = infos[2];
                int numberRepetition = int.Parse(infos[3]);
                int totalRepetition = int.Parse(infos[4]);
                bool isCompleted = bool.Parse(infos[5]);
                RepetitiveTask repetitiveTask = new RepetitiveTask("RepetitiveTask", taskDescription, isCompleted, frequencyRepetition, dueDate, numberRepetition, totalRepetition);
                tasks.Add(repetitiveTask);
            }
            else 
            {
                Console.WriteLine("Error: Task type not found.");
            }
        }
        return tasks;
    }
}
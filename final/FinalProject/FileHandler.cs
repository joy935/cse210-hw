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

    /* methods of the class */
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
        _tasks = new List<Task>();
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
                simpleTask.GetTaskInfo();
                _tasks.Add(simpleTask);
            }
            else if (taskType == "ScheduledTask")
            {
                DateOnly dueDate = DateOnly.Parse(infos[1]);
                bool isCompleted = bool.Parse(infos[2]);
                ScheduledTask scheduledTask = new ScheduledTask("ScheduledTask", taskDescription, isCompleted, dueDate);
                scheduledTask.GetTaskInfo();
                _tasks.Add(scheduledTask);
            }
            else if (taskType == "RepetitiveTask")
            {
                string frequencyRepetition = infos[1];
                DateOnly dueDate = DateOnly.Parse(infos[2]);
                int numberRepetition = int.Parse(infos[3]);
                int totalRepetition = int.Parse(infos[4]);
                bool isCompleted = bool.Parse(infos[5]);
                RepetitiveTask repetitiveTask = new RepetitiveTask("RepetitiveTask", taskDescription, isCompleted, frequencyRepetition, dueDate, numberRepetition, totalRepetition);
                repetitiveTask.GetTaskInfo();
                _tasks.Add(repetitiveTask);
            }
            else 
            {
                Console.WriteLine("Error: Task type not found.");
            }
        }
        return _tasks;
    }
}
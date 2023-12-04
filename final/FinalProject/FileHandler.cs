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
    /* SaveToFile is a method that saves the tasks to a file.
    Parameters: 
        fileName: the name of the file as a string
        List<Task>: the list of tasks 
    Return: none
    */
    public void SaveToFile(string fileName, List<Task> tasks)
    {
        // create a file to write to
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // loop through the list of tasks
            foreach (Task task in tasks)
            {
                // write the task info to the file
                outputFile.WriteLine(task.GetTaskInfo());
            }
        };
        // get the path of the file
        string firstPath = "./final/FinalProject/";
        string filePath = Path.Combine(firstPath, fileName);
    }

    /* LoadFromFile is a method that loads the tasks from a file.
    Parameters: fileName, the name of the file as a string
    Return: List<Task>
    */
    public List<Task> LoadFromFile(string fileName)
    {
        // create a list of tasks
        _tasks = new List<Task>();
        // read the file and store it in a string array
        string [] lines = System.IO.File.ReadAllLines(fileName);

        // loop through the string array
        foreach (string line in lines)
        {
            // split the line into parts
            string [] parts = line.Split(":");

            // get the task type and task details
            string taskType = parts[0];
            string taskDetails = parts[1];

            // split the task details into parts
            string [] infos = taskDetails.Split("~");
            string taskDescription = infos[0];

            // create a task object based on the task type
            if (taskType == "SimpleTask")
            {
                // get the bool for the isCompleted attribute status
                bool isCompleted = bool.Parse(infos[1]);
                // create a simple task object
                SimpleTask simpleTask = new SimpleTask("SimpleTask", taskDescription, isCompleted);
                // get the task info
                simpleTask.GetTaskInfo();
                // add the task to the list of tasks
                _tasks.Add(simpleTask);
            }
            else if (taskType == "ScheduledTask")
            {
                // get the DateOnly for the dueDate attribute
                // and the bool for the isCompleted attribute status
                DateOnly dueDate2 = DateOnly.Parse(infos[1]);
                bool isCompleted2 = bool.Parse(infos[2]);
                // create a scheduled task object
                ScheduledTask scheduledTask = new ScheduledTask("ScheduledTask", taskDescription, dueDate2, isCompleted2);
                // get the task info
                scheduledTask.GetTaskInfo();
                // add the task to the list of tasks
                _tasks.Add(scheduledTask);
            }
            else if (taskType == "RepetitiveTask")
            {
                // get the string for the frequencyRepetition attribute
                // and the DateOnly for the dueDate attribute
                // and the int for the numberRepetition attribute
                // and the int for the totalRepetition attribute
                // and the bool for the isCompleted attribute status
                DateOnly dueDate3 = DateOnly.Parse(infos[1]);
                bool isCompleted3 = bool.Parse(infos[2]);
                string frequencyRepetition = infos[3];
                int numberRepetition = int.Parse(infos[4]);
                int totalRepetition = int.Parse(infos[5]);
                
                // create a repetitive task object
                RepetitiveTask repetitiveTask = new RepetitiveTask("RepetitiveTask", taskDescription, dueDate3, isCompleted3, frequencyRepetition, numberRepetition, totalRepetition);
                // get the task info
                repetitiveTask.GetTaskInfo();
                // add the task to the list of tasks
                _tasks.Add(repetitiveTask);
            }
            else // if the task type is not found
            {
                // display an error message
                Console.WriteLine("Error: Task type not found.");
            }
        }
        // return the list of tasks
        return _tasks;
    }
}
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
        // if the file does not exist
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Error: File does not exist.");
            return null;
        }
        else
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
                bool isCompleted = bool.Parse(infos[1]); // get the bool for the isCompleted attribute status
                
                // create a simple task object
                SimpleTask simpleTask = new SimpleTask("SimpleTask", taskDescription, isCompleted);
                
                simpleTask.GetTaskInfo(); // get the task info
                _tasks.Add(simpleTask); // add the task to the list of tasks
            }
            else if (taskType == "ScheduledTask")
            {
                DateOnly dueDate2 = DateOnly.Parse(infos[1]); // get the DateOnly for the dueDate attribute
                bool isCompleted2 = bool.Parse(infos[2]); // get the bool for the isCompleted attribute status
                
                // create a scheduled task object
                ScheduledTask scheduledTask = new ScheduledTask("ScheduledTask", taskDescription, dueDate2, isCompleted2);
                
                scheduledTask.GetTaskInfo(); // get the task info
                _tasks.Add(scheduledTask); // add the task to the list of tasks
            }
            else if (taskType == "RepetitiveTask")
            {
                DateOnly dueDate3 = DateOnly.Parse(infos[1]); // get the DateOnly for the dueDate attribute
                bool isCompleted3 = bool.Parse(infos[2]); // get the bool for the isCompleted attribute status
                string frequencyRepetition = infos[3]; // get the string for the frequencyRepetition attribute
                int numberRepetition = int.Parse(infos[4]); // get the int for the numberRepetition attribute
                int totalRepetition = int.Parse(infos[5]); // get the int for the totalRepetition attribute
                
                // create a repetitive task object
                RepetitiveTask repetitiveTask = new RepetitiveTask("RepetitiveTask", taskDescription, dueDate3, isCompleted3, frequencyRepetition, numberRepetition, totalRepetition);
                
                repetitiveTask.GetTaskInfo(); // get the task info
                _tasks.Add(repetitiveTask); // add the task to the list of tasks
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
}
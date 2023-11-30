using System;

/* Task Manager Class */
public class TaskManager
{
    /* attributes of the class */
    private string _fileName;   // name of the file
    private List<Task> _tasks;  // list of tasks
    private FileHandler _fileHandler; // file handler

    /* constructor of the class */
    public TaskManager(string fileName, List<Task> tasks)
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
    /* AddTask is a method that adds a task to the list of tasks
    by creating a new task object.
    Parameters: none
    Return: none
    */
    public void AddTask()
    {
        // ask the user what type of task they want to create
        Console.WriteLine("\nThe type of taks are:");
        Console.WriteLine("1. Simple Task");
        Console.WriteLine("2. Scheduled Task");
        Console.WriteLine("3. Repetitive Task");
        // get the user's choice and convert it to an integer
        Console.Write("Which type of task would you like to create? ");
        int taskType = Convert.ToInt32(Console.ReadLine());
        
        // create a task object depending on the user's choice
        switch (taskType)
        {
            case 1:
            // create a simple task
                SimpleTask simpleTask = new SimpleTask("SimpleTask", "description", false);
                Console.Write("What is the description of the task? ");
                string taskDescription = Console.ReadLine();
                // set the task description
                simpleTask.SetTaskDescription(taskDescription);
                // add the task to the list of tasks
                _tasks.Add(simpleTask);
                break;
            case 2:
            // create a scheduled task
                ScheduledTask scheduledTask = new ScheduledTask("ScheduleTask", "description", false, DateOnly.Parse("11/11/24"));
                Console.Write("What is the description of the task? ");
                string taskDescription2 = Console.ReadLine();
                // set the task description
                scheduledTask.SetTaskDescription(taskDescription2);
                Console.Write("What is the due date of the task (MM/DD/YY)? ");
                // set the due date
                DateOnly dueDate = DateOnly.Parse(Console.ReadLine());
                scheduledTask.SetDueDate(dueDate);
                // add the task to the list of tasks
                _tasks.Add(scheduledTask);
                break;
            case 3:
            // create a repetitive task
                RepetitiveTask repetitiveTask = new RepetitiveTask("RepetitiveTask", "description", false, "daily", DateOnly.Parse("12/12/24"), 2, 4);
                Console.Write("What is the description of the task? ");
                string taskDescription3 = Console.ReadLine();
                // set the task description
                repetitiveTask.SetTaskDescription(taskDescription3);
                Console.Write("What is the frequency of the task? ");
                string frequencyRepetition = Console.ReadLine();
                // set the frequency of the task
                repetitiveTask.SetFrequencyRepetition(frequencyRepetition);
                Console.Write("What is the due date of the task (MM/DD/YY)? ");
                // set the due date
                DateOnly dueDate2 = DateOnly.Parse(Console.ReadLine());
                repetitiveTask.SetDueDate(dueDate2);
                Console.Write("How many times has the task been repeated? ");
                // set the total repetition
                int totalRepetition = Convert.ToInt32(Console.ReadLine());
                repetitiveTask.SetTotalRepetition(totalRepetition);
                // set the number of repetition to zero
                repetitiveTask.SetNumberRepetition(0);
                // add the task to the list of tasks
                _tasks.Add(repetitiveTask);
                break;
            default:
            // default case
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    /* DisplayTasks is a method that displays the tasks in a list format.
    Parameters: None
    Return: none
    */
    public void DisplayTasks()
    {   
        // display the list of tasks
        Console.WriteLine("To-do list: ");
        foreach (Task task in _tasks)   // for each task in the list of tasks
        {
            task.DisplayTaskInfo();     // display the task info
        }
    }

    /* SaveTasks is a method that saves the tasks to a file
    by calling the SaveToFile method from the FileHandler class.
    Parameters: None
    Return: none
    */
    public void SaveTasks()
    {
        // ask the user for the filename
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        // create a file handler object
        _fileHandler = new FileHandler(fileName, _tasks);
        // save the tasks to the file by calling the SaveToFile method
        _fileHandler.SaveToFile(fileName, _tasks);
    }

    /* LoadTasks is a method that loads the tasks from a file
    by calling the LoadFromFile method from the FileHandler class.
    Parameters: None
    Return: none
    */
    public List<Task> LoadTasks(string filename)
    {
        // create a file handler object
        _fileHandler = new FileHandler(filename, _tasks);
        // load the tasks from the file by calling the LoadFromFile method
        return _fileHandler.LoadFromFile(filename);
    }

    /* CompleteTask CompleteTask is a method that updates the task when it
    is completed by calling the MarkComplete method from the Task class.
    Parameters: 
        int taskIndex, the index of the task to update
        List<Task> tasks, the list of tasks
    Return: none
    */
    public void CompleteTask(int taskIndex, List<Task> tasks)
    {
        // check if the task index is valid
        if (taskIndex >= 0 && taskIndex < tasks.Count)
        {
            // get the task to update
            Task taskToUpdate = tasks[taskIndex - 1];
            // update the task
            taskToUpdate.MarkComplete();
        }
        // if the task index is not valid
        else
        {
            Console.WriteLine("Invalid task index. Please try again.");
        }
    }
    
    /* TaskOrganizer is a method that organizes the tasks by due date, 
    removes the tasks that are completed from the list of tasks 
    ???
    */
}
using System;

/* Task Manager Class */
public class TaskManager
{
    /* attributes of the class */
    private string _fileName;           // name of the file
    private List<Task> _tasks;          // list of tasks
    private FileHandler _fileHandler;   // file handler

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
    /* AddSimpleTask is a method that creates a simple task and 
    adds it to the list of tasks.
    Parameters: none
    Return: none
    */
    public void AddSimpleTask()
    {
        // create a simple task
        SimpleTask simpleTask = new SimpleTask("SimpleTask", "description", false);
        Console.Write("\nWhat is the description of the task? ");
        string taskDescription = Console.ReadLine();
        // set the task description
        simpleTask.SetTaskDescription(taskDescription);
        // add the task to the list of tasks
        _tasks.Add(simpleTask);
    }

    /* AddScheduledTask is a method that creates a scheduled task and
    adds it to the list of tasks.
    Parameters: none
    Return: none
    */
    public void AddScheduledTask()
    {
        // create a scheduled task
        ScheduledTask scheduledTask = new ScheduledTask("ScheduleTask", "description", DateOnly.Parse("11/11/24"), false);
        Console.Write("\nWhat is the description of the task? ");
        string taskDescription2 = Console.ReadLine();
        // set the task description
        scheduledTask.SetTaskDescription(taskDescription2);
        Console.Write("What is the due date of the task (YYYY/MM/DD)? ");
        DateOnly dueDate2 = DateOnly.Parse(Console.ReadLine());
        // set the due date
        scheduledTask.SetDueDate(dueDate2);
        // add the task to the list of tasks
        _tasks.Add(scheduledTask);
    }

    /* AddRepetitiveTask is a method that creates a repetitive task and
    adds it to the list of tasks.
    Parameters: none
    Return: none
    */
    public void AddRepetitiveTask()
    {
        // create a repetitive task
        RepetitiveTask repetitiveTask = new RepetitiveTask("RepetitiveTask", "description", DateOnly.Parse("12/12/24"), false, "daily", 2, 4);
        Console.Write("\nWhat is the description of the task? ");
        string taskDescription3 = Console.ReadLine();
        // set the task description
        repetitiveTask.SetTaskDescription(taskDescription3);
        Console.Write("What is the frequency of the task (daily, weekly, monthly, yearly)? ");
        string frequencyRepetition = Console.ReadLine();
        // set the frequency of the task
        repetitiveTask.SetFrequencyRepetition(frequencyRepetition);
        Console.Write("What is the due date of the task (YYYY/MM/DD)? ");
        // set the due date
        DateOnly dueDate3 = DateOnly.Parse(Console.ReadLine());
        repetitiveTask.SetDueDate(dueDate3);
        Console.Write("How many times has the task been repeated? ");
        // set the total repetition
        int totalRepetition = Convert.ToInt32(Console.ReadLine());
        repetitiveTask.SetTotalRepetition(totalRepetition);
        // set the number of repetition to zero
        repetitiveTask.SetNumberRepetition(0);
        // add the task to the list of tasks
        _tasks.Add(repetitiveTask);
    }

    /* DisplayTasks is a method that displays the tasks in a list format.
    Parameters: None
    Return: none
    */
    public void DisplayTasks()
    {   
        TaskScheduler taskScheduler = new TaskScheduler(_tasks);
        _tasks = taskScheduler.SortByDueDate(); // sort the tasks by due date
        taskScheduler.RemoveAccomplishedTasks(); // remove the accomplished tasks
        
        Console.WriteLine();
        taskScheduler.OverDueTasks(); // display the overdue tasks
        
        // display the list of tasks
        Console.WriteLine();
        Console.WriteLine("-------- To-do list --------");
        int i = 1;
        foreach (Task task in _tasks)   // for each task in the list of tasks
        {
            Console.Write($"{i}. ");
            task.DisplayTaskInfo();     // display the task info
            i++;
        }
    }

    /* DisplayAllTasks is a method that displays all tasks in a list format
    to allow the user to choose a task to complete. Note: It also displays
    the accomplished tasks.
    Parameters: None
    Return: none
    */
    public void DisplayAllTasks()
    {
        TaskScheduler taskScheduler2 = new TaskScheduler(_tasks);
        Console.WriteLine();
        taskScheduler2.OverDueTasks();

        Console.WriteLine();
        Console.WriteLine("-------- To-do list --------");
        int i = 1;
        foreach (Task task in _tasks)   // for each task in the list of tasks
        {
            Console.Write($"{i}. ");
            task.DisplayTaskInfo();     // display the task info
            i++;
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
        _fileHandler = new FileHandler(fileName, _tasks);
        // save the tasks to the file by calling the SaveToFile method
        _fileHandler.SaveToFile(fileName, _tasks);
    }

    /* LoadTasks is a method that loads the tasks from a file
    by calling the LoadFromFile method from the FileHandler class.
    Parameters: filename, the name of the file
    Return: none
    */
    public List<Task> LoadTasks(string filename)
    {
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
        if (taskIndex >= 0 && taskIndex - 1 < tasks.Count)
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

    /* DisplayAccomplishedTasks is a method that displays all 
    accomplished tasks.
    Parameters: none
    Return: none
    */
    public void DisplayAccomplishedTasks()
    {
        Console.WriteLine("Accomplished tasks:");
        // loop through the list of tasks
        foreach (Task task in _tasks)
        {
            // if the task is accomplished, display the task info
            if (task.GetIsCompleted() == true)
            {
                task.DisplayTaskInfo();
            }
        }
    }
}
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
    /* AddTask ...
    */
    public void AddTask()
    {
        Console.WriteLine("\nThe type of taks are:");
        Console.WriteLine("1. Simple Task");
        Console.WriteLine("2. Scheduled Task");
        Console.WriteLine("3. Repetitive Task");
        Console.Write("Which type of task would you like to create? ");
        int taskType = Convert.ToInt32(Console.ReadLine());
        
        switch (taskType)
        {
            case 1:
                SimpleTask simpleTask = new SimpleTask("SimpleTask", "description", false);
                Console.Write("What is the description of the task? ");
                string taskDescription = Console.ReadLine();
                simpleTask.SetTaskDescription(taskDescription);
                _tasks.Add(simpleTask);
                break;
            case 2:
                ScheduledTask scheduledTask = new ScheduledTask("ScheduleTask", "description", false, DateOnly.Parse("11/11/24"));
                Console.Write("What is the description of the task? ");
                string taskDescription2 = Console.ReadLine();
                scheduledTask.SetTaskDescription(taskDescription2);
                Console.Write("What is the due date of the task (MM/DD/YY)? ");
                DateOnly dueDate = DateOnly.Parse(Console.ReadLine());
                scheduledTask.SetDueDate(dueDate);
                _tasks.Add(scheduledTask);
                break;
            case 3:
                RepetitiveTask repetitiveTask = new RepetitiveTask("RepetitiveTask", "description", false, "daily", DateOnly.Parse("12/12/24"), 2, 4);
                Console.Write("What is the description of the task? ");
                string taskDescription3 = Console.ReadLine();
                repetitiveTask.SetTaskDescription(taskDescription3);
                Console.Write("What is the frequency of the task? ");
                string frequencyRepetition = Console.ReadLine();
                repetitiveTask.SetFrequencyRepetition(frequencyRepetition);
                Console.Write("What is the due date of the task (MM/DD/YY)? ");
                DateOnly dueDate2 = DateOnly.Parse(Console.ReadLine());
                repetitiveTask.SetDueDate(dueDate2);
                Console.Write("How many times has the task been repeated? ");
                int totalRepetition = Convert.ToInt32(Console.ReadLine());
                repetitiveTask.SetTotalRepetition(totalRepetition);
                repetitiveTask.SetNumberRepetition(0);
                _tasks.Add(repetitiveTask);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    /* DisplayTasks ...
    */
    public void DisplayTasks()
    {   
        Console.WriteLine("To-do list: ");
        foreach (Task task in _tasks)   // for each task in the list of tasks
        {
            task.DisplayTaskInfo();     // display the task info
        }
    }

    /* SaveTasks ...
    */
    public void SaveTasks()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        _fileHandler = new FileHandler(fileName, _tasks);
        _fileHandler.SaveToFile(fileName, _tasks);
    }

    /* LoadTasks ...
    */
    public List<Task> LoadTasks(string filename)
    {
        _fileHandler = new FileHandler(filename, _tasks);
        return _fileHandler.LoadFromFile(filename);
    }

    /* CompleteTask ...
    */
    
    /* RemoveTask ...???
    */

    /* SortTasks ... ???
    */

    /* OverDueTasks ... ???
    */
}
using System;

/* Task Manager Class */
public class TaskManager
{
    /* attributes of the class */
    private string _fileName;   // name of the file
    private List<Task> _tasks;  // list of tasks

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

    /* AddTask ...
    */
    public void AddTask()
    {
        foreach (Task task in _tasks)
        {
            /// add task to list
        }
    }

    /* RemoveTask ...
    */
    

    /* DisplayTasks ...
    */
    public void DisplayTasks()
    {
        foreach (Task task in _tasks)
        {
            task.DisplayTaskInfo();
        }
    }

    /* SaveTasks ...
    */
    public void SaveTasks()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();
        FileHandler fileHandler = new FileHandler(fileName, List<Task> tasks);
        fileHandler.SaveToFile(fileName, _tasks);
    }

    /* LoadTasks ...
    */
    public void LoadTasks()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();
        FileHandler fileHandler = new FileHandler(fileName, List<Task> tasks);
        fileHandler.LoadFromFile(fileName);
    }

    /* SortTasks ...
    */

    /* OverDueTasks ...
    */

    /* CompleteTask ...
    */
}
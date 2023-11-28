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
    
}
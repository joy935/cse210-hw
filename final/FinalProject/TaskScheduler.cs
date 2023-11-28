using System;

/* Task Scheduler Class */
public class TaskScheduler
{
    /* attributes of the class */
    private List<Task> _tasks;   // list of tasks

    /* constructor of the class */
    public TaskScheduler(List<Task> tasks)
    {
        _tasks = tasks;
    }
}
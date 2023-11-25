using System;

/* ScheduledTask Derived Class */
public class ScheduledTask : Task
{
    /* attributes of the class */
    private DateTime _dueDate; // due date of the task

    /* constructor of the class */
    public ScheduledTask(string taskType, string taskDescription, bool isCompleted, DateTime dueDate) : base(taskType, taskDescription, isCompleted)
    {
        _dueDate = dueDate;
    }
}
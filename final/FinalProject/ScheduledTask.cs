using System;

/* ScheduledTask Derived Class */
public class ScheduledTask : Task
{
    /* attributes of the class */
    private DateTime _dueDate; // due date of the task

    /* constructor of the class */
    public ScheduledTask(string taskDescription, bool isCompleted, DateTime dueDate) : base(taskDescription, isCompleted)
    {
        _dueDate = dueDate;
    }

    /* Getters and setters for the attributes of the class */
    public DateTime GetDueDate()
    {
        return _dueDate;
    }
    public void SetDueDate(DateTime dueDate)
    {
        _dueDate = dueDate;
    }

    /* GetTaskInfo ...
    */
    public override string GetTaskInfo()
    {
        if (_isCompleted == true)
        {
            return $"ScheduledTask:{_taskDescription}~{_dueDate}~True";
        }
        else
        {
            return $"ScheduledTask:{_taskDescription}~{_dueDate}~False";
        }
    }

    /* DisplayTaskInfo ...
    */
    public override void DisplayTaskInfo()
    {

    }

    /* MarkComplete ...
    */
    public override bool MarkComplete()
    {

    }

}
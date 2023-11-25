using System;

/* SimpleTask Derived Class */
public class SimpleTask : Task
{
    // no attributes

    /* constructor of the class */
    public SimpleTask(string type, string taskDescription, bool isCompleted) : base(type, taskDescription, isCompleted)
    {}

    /* GetTaskInfo ...
    */
    public override string GetTaskInfo()
    {
        if (_isCompleted == true)
        {
            return $"SimpleTask:{_taskDescription}~True";
        }
        else
        {
            return $"SimpleTask:{_taskDescription}~False";
        }
    }

    /* DisplayTaskInfo ...
    */
    public override void DisplayTaskInfo()
    {
        Console.WriteLine($"{_taskDescription}");
    }
}
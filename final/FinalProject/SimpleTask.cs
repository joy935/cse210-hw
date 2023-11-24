using System;

/* SimpleTask Derived Class */
public class SimpleTask : Task
{
    // no attributes

    /* constructor of the class */
    public SimpleTask(string taskType, string taskDescription, bool isCompleted) : base(taskType, taskDescription, isCompleted)
    {}

    
}
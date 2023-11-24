using System;

/* Task Base Class */
public abstract class Task
{ 

    /* attributes of the class */
    protected string _taskType;         // type of task
    protected string _taskDescription;  // description of task
    protected bool _isCompleted;        // is the task complete?

    /* constructor of the class */
    public Task(string taskType, string taskDescription, bool isCompleted)
    {
        _taskType = taskType;
        _taskDescription = taskDescription;
        _isCompleted = isCompleted;
    }

    /* Getters and setters for the attributes of the class */
    public string GetTaskType()
    {
        return _taskType;
    }
    public void SetTaskType(string taskType)
    {
        _taskType = taskType;
    }
    public string GetTaskDescription()
    {
        return _taskDescription;
    }
    public void SetTaskDescription(string taskDescription)
    {
        _taskDescription = taskDescription;
    }
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public void SetIsCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    /* GetTaskInfo ...
    */
    public abstract string GetTaskInfo();

    /* MarkComplete ...
    */
    public abstract bool MarkComplete();
}

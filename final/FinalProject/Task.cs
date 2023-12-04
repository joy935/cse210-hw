using System;

/* Task Base Class */
public abstract class Task
{ 

    /* attributes of the class */
    protected string _taskType;         // type of task
    protected string _taskDescription;  // description of task
    protected DateOnly _dueDate;        // due date of task
    protected bool _isCompleted;        // is the task complete?

    /* constructors of the class */
    public Task(string taskType, string taskDescription, DateOnly dueDate, bool isCompleted)
    {
        _taskType = taskType;
        _taskDescription = taskDescription;
        _dueDate = dueDate;
        _isCompleted = isCompleted;
    }
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

    /* methods of the class */
    /* GetTaskInfo is an abstract method that returns the task info
    in a specific format to be saved later in a file.
    It is implemented in the derived classes.
    Parameters: none
    Return: string
    */
    public abstract string GetTaskInfo();

    /* DisplayTaskInfo is an abstract method that displays the task info.
    It is implemented in the derived classes.
    Parameters: none
    Return: none
    */
    public abstract void DisplayTaskInfo();

    /* MarkComplete is a method that marks the task as complete.
    Parameters: none
    Return: bool
    */
    public virtual bool MarkComplete()
    {
        _isCompleted = true;
        return _isCompleted;
    }
}

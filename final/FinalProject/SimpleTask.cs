using System;

/* SimpleTask Derived Class */
public class SimpleTask : Task
{
    // no attributes

    /* constructor of the class */
    public SimpleTask(string taskType, string taskDescription, bool isCompleted) : base(taskType, taskDescription, isCompleted)
    {}

    /* methods of the class */
    /* GetTaskInfo is a method that returns the task info 
    in a specific format to be saved later in a file.
    If the task is completed, the method returns the task info
    with the isCompleted attribute set to true. Otherwise, it returns
    the task info with the isCompleted attribute set to false.
    Parameters: none
    Return: string
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

    /* DisplayTaskInfo is a method that displays the task info.
    Parameters: none
    Return: none
    */
    public override void DisplayTaskInfo()
    {
        Console.WriteLine($"{_taskDescription}");
    }
}
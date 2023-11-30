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

    /* Getters and setters for the attributes of the class */
    public List<Task> GetTasks()
    {
        return _tasks;
    }
    public void SetTasks(List<Task> tasks)
    {
        _tasks = tasks;
    }

    /* methods of the class */
    /* SortByDueDate is a method that sorts the list of tasks by due date.
    Parameters: none
    Return: none
    */
    public void SortByDueDate()
    {
        // sort the list of tasks by due date
    }

    /* OverDueTasks is a method that displays all tasks that are overdue.
    Parameters: none
    Return: none
    */
    public void OverDueTasks()
    {
        // display all tasks that are overdue
    }

    /* RemoveAccomplishedTasks is a method that removes all tasks that 
    are accomplished.
    Parameters: none
    Return: none
    */
    public void RemoveAccomplishedTasks()
    {
        // remove all tasks that are accomplished
    }
}
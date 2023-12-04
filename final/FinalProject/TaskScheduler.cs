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
    public List<Task> SortByDueDate()
    {
        List<Task> sortedTasks = new List<Task>();
        // sort the list of tasks by due date
        sortedTasks = _tasks.OrderBy(task => task.GetDueDate()).ToList();
        // add the sorted tasks to the sortedTasks list
        _tasks = sortedTasks;
        foreach (Task task in _tasks)
        {
            Console.WriteLine(task.GetTaskInfo());
        }
        return _tasks;
    }

    /* OverDueTasks is a method that displays all tasks that are overdue.
    Parameters: none
    Return: none
    */
    public void OverDueTasks()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        Console.WriteLine("*** Overdue Tasks ***");
        // loop through the list of tasks
        foreach (Task task in _tasks)
        {
            // don't display the task if it is accomplished
            // don't display the task if it is simple task
            
            // if the task is overdue, display the task info
            if (task.GetDueDate() < today)
            {
                task.DisplayTaskInfo();
            }
        }
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
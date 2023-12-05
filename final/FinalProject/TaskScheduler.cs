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
            task.GetTaskInfo();
        }
        return _tasks;
    }

    public bool IsOverdue()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        foreach (Task task in _tasks)
        {
            // if the task is overdue, return true
            if (task.GetDueDate() < today && !task.GetIsCompleted())
            {
                return true;
            }
        }
        return false;
    }

    /* OverDueTasks is a method that displays all tasks that are overdue.
    Parameters: none
    Return: none
    */
    public void OverDueTasks()
    {
        if (IsOverdue() == true)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            Console.WriteLine("****** Overdue Tasks ******");
            // loop through the list of tasks
            foreach (Task task in _tasks)
            {             
                // if the task is overdue, not completed and not a simple task, display the task info
                if (task.GetDueDate() < today && !task.GetIsCompleted() && task.GetTaskType() != "SimpleTask")
                {
                    task.DisplayTaskInfo();
                }
            }
        }
        else 
        {
            Console.WriteLine("There are no overdue tasks.");
        }

    }

    /* RemoveAccomplishedTasks is a method that removes all tasks that 
    are accomplished.
    Parameters: none
    Return: none
    */
    public void RemoveAccomplishedTasks()
    {
        // loop through the list of tasks
        for(int i = _tasks.Count - 1; i >= 0; i--)
        {
            // if the task is accomplished, remove the task
            if (_tasks[i].GetIsCompleted() == true)
            {
                _tasks.RemoveAt(i);
            }
        }
    }
}
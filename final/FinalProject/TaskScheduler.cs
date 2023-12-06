using System;

/* Task Scheduler Class */
public class TaskScheduler
{
    /* attribute of the class */
    private List<Task> _tasks;   // list of tasks

    /* constructor of the class */
    public TaskScheduler(List<Task> tasks)
    {
        _tasks = tasks;
    }

    /* Getter and setter for the attribute of the class */
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
    Return: list of tasks
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
            // get the task information
            task.GetTaskInfo();
        }
        return _tasks;
    }

    /* IsOverdue is a method that checks if there are any overdue tasks
    in the list of tasks.
    Parameters: none
    Return: a boolean value, true if there are overdue tasks, false otherwise
    */
    public bool IsOverdue()
    {
        // get today's date
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        // loop through the list of tasks
        foreach (Task task in _tasks)
        {
            // if the task is overdue and not accomplished , return true
            if (task.GetDueDate() < today && !task.GetIsCompleted())
            {
                // return true if there are overdue tasks
                return true;
            }
        }
        // return false if there are no overdue tasks
        return false;
    }

    /* OverDueTasks is a method that displays all tasks that are overdue,
    not completed and not a simple task.
    Parameters: none
    Return: none
    */
    public void OverDueTasks()
    {
        // check if there are overdue tasks
        if (IsOverdue() == true)
        {
            // get today's date
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            Console.WriteLine("****** Overdue Tasks ******");
            // loop through the list of tasks
            foreach (Task task in _tasks)
            {             
                // if the task is overdue, not completed and not a simple task, display the task info
                if (task.GetDueDate() < today && !task.GetIsCompleted() && task.GetTaskType() != "SimpleTask")
                {
                    // display the task info
                    task.DisplayTaskInfo();
                }
            }
        }
        else // if there are no overdue tasks
        {
            Console.WriteLine("Great job, there are no overdue tasks!");
        }

    }

    /* RemoveAccomplishedTasks is a method that removes all tasks that 
    are accomplished from the list of tasks.
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
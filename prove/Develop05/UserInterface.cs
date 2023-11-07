using System;
using System.Collections.Generic;

/* User Interface Class */
public class UserInterface
{
    private List<Goal> _goals;

    public UserInterface(List<Goal> goals)
    {
        _goals = goals;
    }

    public void UpdateGoal(int goalIndex)
    {
        // foreach (Goal goal in goals)
        // {
        //     for (int i = 0; i < this._goals.Count; i++)
        //     {
        //         if (i == goalIndex)
        //         {
        //             this._goals[i].RecordEvent();
        //             Console.WriteLine(goals[i]);
        //         }
        //     }
        // }
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            Console.WriteLine(goal);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
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

    public void UpdateGoal(int numberGoal, List<Goal> goals)
    {
        foreach (Goal goal in goals)
        {
            for (int i = 0; i < this._goals.Count; i++)
            {
                if (i == numberGoal)
                {
                    this._goals[i].RecordEvent();
                    Console.WriteLine(goals[i]);
                }
            }
        }
    }
}
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

public void UpdateGoal(int goalIndex, List<Goal> goals)
{
    if (goalIndex >= 0 && goalIndex < goals.Count)
    {
        Goal goalToUpdate = goals[goalIndex];
        goalToUpdate.RecordEvent(); // to update the existing goal
        Console.WriteLine(goalToUpdate.GetStringRepresentation()); // test to display the updated goal
    }
    else
    {
        Console.WriteLine("Invalid goal index. Please try again.");
    }
}
}
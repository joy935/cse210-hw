using System;
using System.Collections.Generic;

/* User Interface Class */
public class UserInterface
{
    // attribute of the class
    private List<Goal> _goals; // a list of Goal objects

    /* UserInterface is a constructor method that creates an instance of the UserInterface class.
    Parameters: List<Goal> goals
    Return: none
    */

    public UserInterface(List<Goal> goals)
    {
        _goals = goals;
    }

    /* ListGoals is a method that updates the goal when it 
    is completed
    Parameters: goalIndex and goals
    Return: none
    */
    public int UpdateGoal(int goalIndex, List<Goal> goals)
    {
        // check if the goal index is valid
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            // get the goal to update
            Goal goalToUpdate = goals[goalIndex];
            // update the goal
            goalToUpdate.RecordEvent();
            return goalToUpdate.GetPoints(); // return the points of the goal
        }
        // if the goal index is not valid
        else
        {
            Console.WriteLine("Invalid goal index. Please try again.");
            return 0; // return 0 points
        }
    }
}
using System;

/* Game Class */
public class Game
{
    // attribute of the class
    private int _totalPoints; // the total points of the game

    /* Game is a constructor method that creates an instance 
    of the Game class.
    Parameters: int totalPoints
    Return: none
    */
    public Game(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    /* Getter and Setter Method */
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    /* LevelUp is a method that returns the level of the game
    according to the total points.
    Parameters: none
    Return: string
    */
    public string LevelUp()
    {
        // if the total points is greater than or equal to 100000 points
        if (_totalPoints >= 10000)
        {
            Console.WriteLine("You have reached a Master level!");
            return "Master";
        }
        // if the total points is greater than or equal to 5000 points
        else if (_totalPoints >= 5000)
        {
            Console.WriteLine("You have reached an Expert level!");
            return "Expert"; // expert level
        }
        // if the total points is greater than or equal to 2000 points
        else if (_totalPoints >= 2000)
        {
            Console.WriteLine("You have reached an Advanced level!");
            return "Advanced"; // advanced level
        }
        // if the total points is greater than or equal to 500 points
        else if (_totalPoints >= 500)
        {
            Console.WriteLine("You have reached an Apprentice level!");
            return "Apprentice"; // apprentice level
        }
        // if the total points is less than 500 points
        else 
        {
            Console.WriteLine("You have a Beginner level.");
            return "Beginner"; // beginner level
        }
    }

    /* DisplayLevel is a method that displays how
    many points are needed to level up
    according to the total points.
    Parameters: none
    Return: none
    */
    public void DisplayLevel()
    {
        string level = LevelUp();   // get the level of the game
        int pointsNeeded = 0;       // the points needed to level up

        // if the level is Beginner
        if (level == "Apprentice")
        {
            pointsNeeded = 2000 - _totalPoints; // compute the points needed
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
        // if the level is Advanced
        else if (level == "Advanced")
        {
            pointsNeeded = 5000 - _totalPoints;
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
        // if the level is Expert
        else if (level == "Expert")
        {
            pointsNeeded = 10000 - _totalPoints;
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
        // if the level is Master
        else if (level == "Master")
        {
            pointsNeeded = 100000 - _totalPoints; // what to do there?
        }
        // if the level is Beginner
        else
        {
            pointsNeeded = 500 - _totalPoints;
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
    }
}

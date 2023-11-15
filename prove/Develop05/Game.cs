using System;

/* Game Class */
public class Game
{
    private int _totalPoints;

    public Game(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public string LevelUp()
    {
        if (_totalPoints >= 10000)
        {
            Console.WriteLine("You have reached a Master level!");
            return "Master";
        }
        else if (_totalPoints >= 5000)
        {
            Console.WriteLine("You have reached an Expert level!");
            return "Expert";
        }
        else if (_totalPoints >= 2000)
        {
            Console.WriteLine("You have reached an Advanced level!");
            return "Advanced";
        }
        else if (_totalPoints >= 500)
        {
            Console.WriteLine("You have reached an Apprentice level!");
            return "Apprentice";
        }
        else
        {
            Console.WriteLine("You have a Beginner level.");
            return "Beginner";
        }
    }
    public void DisplayLevel()
    {
        string level = LevelUp();
        int pointsNeeded = 0;

        if (level == "Apprentice")
        {
            pointsNeeded = 2000 - _totalPoints;
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
        else if (level == "Advanced")
        {
            pointsNeeded = 5000 - _totalPoints;
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
        else if (level == "Expert")
        {
            pointsNeeded = 10000 - _totalPoints;
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
        else if (level == "Master")
        {
            pointsNeeded = 100000 - _totalPoints; // what to do there?
        }
        else
        {
            pointsNeeded = 500 - _totalPoints;
            Console.WriteLine($"You are at {pointsNeeded} points to level up.");
        }
    }
}

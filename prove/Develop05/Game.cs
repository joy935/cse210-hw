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
            Console.WriteLine("You have leveled up to Master!");
            return "Master";
        }
        else if (_totalPoints >= 5000)
        {
            Console.WriteLine("You have leveled up to Expert!");
            return "Expert";
        }
        else if (_totalPoints >= 2000)
        {
            Console.WriteLine("You have leveled up to Advanced!");
            return "Advanced";
        }
        else if (_totalPoints >= 500)
        {
            Console.WriteLine("You have leveled up to Apprentice!");
            return "Apprentice";
        }
        else
        {
            Console.WriteLine("You have not leveled up yet.");
        }
    }
    public void DisplayLevel()
    {
        string level = LevelUp();
        int pointsNeeded = 0;
        if (level == "Apprentice")
        {
            pointsNeeded = 500 - _totalPoints;
        }
        else if (level == "Advanced")
        {
            pointsNeeded = 2000 - _totalPoints;
        }
        else if (level == "Expert")
        {
            pointsNeeded = 5000 - _totalPoints;
        }
        else if (level == "Master")
        {
            pointsNeeded = 10000 - _totalPoints;
        }
        Console.WriteLine($"Your current level is: {level}.");
        Console.WriteLine($"You are at {pointsNeeded} to level up.")
    }

}

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
    public void LevelUp()
    {
        if (_totalPoints >= 500)
        {
            _totalPoints += 250;
            Console.WriteLine("You have leveled up to Apprentice!");
            Console.WriteLine("You have earned 250 extra points!");
        }
        else if (_totalPoints >= 2000)
        {
            _totalPoints += 500;
            Console.WriteLine("You have leveled up to Advanced!");
            Console.WriteLine("You have earned 500 extra points!");
        }
        else if (_totalPoints >= 10000)
        {
            _totalPoints += 1000;
            Console.WriteLine("You have leveled up to Master!");
            Console.WriteLine("You have earned 1000 extra points!");
        }
    }
}

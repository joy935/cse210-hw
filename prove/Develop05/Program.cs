using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal sGoal = new SimpleGoal("Read the scriptures", "Read in the morning", 10, 0);
        Console.WriteLine(sGoal.CreateGoal());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeUser = Console.ReadLine();
        int grade = int.Parse(gradeUser);
        string letter = "A";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >=70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have {letter}.");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you pass!");
        }
        else
        {
            Console.WriteLine("Do better next time.");
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeUser = Console.ReadLine();
        int grade = int.Parse(gradeUser);

        if (grade >= 90)
        {
            Console.WriteLine($"You have an A.");
        }
        else if (grade >=80)
        {
            Console.WriteLine($"You have a B.");
        }
        else if (grade >=70)
        {
            Console.WriteLine($"You have a C.");
        }
        else if (grade >=60)
        {
            Console.WriteLine($"You have a D.");
        }
        else
        {
            Console.WriteLine($"You have a F.");
        }
        
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
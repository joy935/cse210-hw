using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeUser = Console.ReadLine();
        int grade = int.Parse(gradeUser);
        Console.WriteLine($"Your grade is {grade}");
    }
}
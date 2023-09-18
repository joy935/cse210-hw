using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user's grade percentage and store it in gradeUser as an int //
        Console.Write("What is your grade percentage? ");
        string gradeUser = Console.ReadLine();
        int grade = int.Parse(gradeUser);

        // letter is a the variable to store the letter corresponding to the grade //
        string letter = "";

        // Check conditions to determine which letter correspond to the grade //
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

        // sign is the variable to store the sign of the grade letter // 
        string sign = "";

        // get the sign grade by dividing the grade by 10 and get the remainder //
        int signGrade = grade % 10;

        // check conditions to determine - or + sign of the grade //
        if (signGrade >= 7)
        {
            sign = "+";
        }
        else if (signGrade < 3)
        {
            sign = "-";
        }

        // check exceptions: A+ becomes A and F- and F+ becomes F //
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F" && sign =="-" || sign =="+")
        {
            sign = "";
        }

        // display the grade with the letter and sign, if applicable //
        Console.WriteLine($"You have {letter}{sign}.");
        
        // display a message corresponding to the passing of the class or not //
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
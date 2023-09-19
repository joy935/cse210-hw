using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sNumber = SquareNumber(userNumber);
        DisplayResult(userName, sNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int sNumber = (number * number);
            return sNumber;
        }

        static void DisplayResult(string userName, int sNumber)
        {
            Console.Write($"{userName}, the square of your number is {sNumber}. ");
        }
    }
}
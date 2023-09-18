using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);


    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.Write("What is your magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guessNumber = 0;

        do {
            Console.Write("What is your guess? ");
            string guess2 = Console.ReadLine();
            int guessNumber2 = int.Parse(guess2);

            if (guessNumber2 == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else 
            {
                if (guessNumber2 > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else {
                    Console.WriteLine("Higher");
                }

            }
        } while (guessNumber != magicNumber);
        
    }
}
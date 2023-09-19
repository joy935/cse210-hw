using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.Write("What is your magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);
        
        string playAgain;

        do {
            Console.WriteLine("Let's guess the magic number! ");

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            int guessNumber = 0;
            int guesses = 0;

            do {
                Console.Write("What is your guess? ");
                string guess2 = Console.ReadLine();
                int guessNumber2 = int.Parse(guess2);

                if (guessNumber2 == magicNumber)
                {
                    guesses += 1;
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesses} guess.");
                    Console.WriteLine("Do you want to play again? (yes or no) ");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "no")
                    {
                        break;
                    }
                    
                }
                else 
                {
                    if (guessNumber2 > magicNumber)
                    {
                        Console.WriteLine("Lower");
                        guesses += 1;
                    }
                    else {
                        Console.WriteLine("Higher");
                        guesses += 1;
                    }

                }
            } while (guessNumber != magicNumber);
        } while (playAgain == "yes");
        
        
    }
}
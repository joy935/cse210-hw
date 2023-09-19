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

            int guesses = 0;

            do {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                int guessNumber = int.Parse(guess);

                if (guessNumber == magicNumber)
                {
                    guesses += 1;
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesses} guess.");
                    break;
                    
                }
                else 
                {
                    if (guessNumber > magicNumber)
                    {
                        Console.WriteLine("Lower");
                        guesses += 1;
                    }
                    else {
                        Console.WriteLine("Higher");
                        guesses += 1;
                    }

                }
            } while (true);
            Console.WriteLine("Do you want to play again? (yes or no) ");
            playAgain = Console.ReadLine();
        } while (playAgain.ToLower() == "yes");
    }
}
using System;

/* Reflecting Activity derived class */
public class ReflectingActivity : Activity
{
    // attributes of the class
    private List<string> _prompts = new List<string>    // list of prompts
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string> // list of questions
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    /*  ReflectingActivity is a constructor method that creates an instance of the ReflectingActivity class
    by calling the constructor of the base class.
    Parameters: string nameActivity, string description, int duration
    Return: none
    */
    public ReflectingActivity(string nameActivity, string description, int duration) : base (nameActivity, description, duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    /* GetPrompt is a method that returns a random prompt from the list of prompts.
    Parameters: none
    Return: string, a random prompt
    */
    public string GetPrompt()
    {
        // create a random object
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        // return a random prompt
        return _prompts[i];
    }

    /* GetQuestion is a method that returns a random question from the list of questions.
    Parameters: none
    Return: string, a random question
    */
    public string GetQuestion()
    {
        // create a list of indexes
        List<int> listIndexes = new List<int>();
        // create a random object
        Random random = new Random();
        // create a random index
        int randomIndex;
        // get a different random question from the list
        do
        {
            randomIndex = random.Next(_questions.Count);
        } while (listIndexes.Contains(randomIndex));
        // add the random index to the list
        listIndexes.Add(randomIndex);
        // return the random question
        return _questions[randomIndex];
    }

    /* DisplayPrompt is a method that displays the prompt and
    uses the PauseCountdown method to display the countdown.
    Parameters: none
    Return: none
    */
    public string DisplayPrompt()
    {
        // display the prompt
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetPrompt()} ---\n");
        // ask the user to press enter to continue
        Console.Write("When you have something in mind, press enter to continue.");
        // get the user's input
        string ready = Console.ReadLine();
        // ask the user to ponder on the question or questions
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("");
        Console.Write("You may begin in: ");
        // display the countdown
        PauseCountdown();
        Console.Clear();
        // return the user's input to continue
        return ready;
    }

    /* DisplayQuestion is a method that displays the question
    and uses the PauseSpinner method to display the spinner.
    Parameters: none
    Return: none
    */
    public void DisplayQuestion()
    {
        // get the question
        string question = GetQuestion();
        // display the question
        Console.Write($"> {question}");
        // display the spinner
        PauseSpinner();
        Console.WriteLine("");
    }
}
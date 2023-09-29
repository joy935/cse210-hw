using System;

// create a class named Prompt
public class Prompt
{
    // define the class attribute _promptList which is a list of prompts
    private static List<string> _promptList = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What have I done differently today?",
        "What is something unexpected that happened today?",
        "If I could change one thing from today, what would it be?",
        "List 3 things that helped me feel happy today.",
        "List 3 things I am grateful for.",
    };

    /* GetRandomPrompt defines the class behavior to get a random 
    prompt from the list of prompts 
    Parameter: none
    Return : a prompt */
    public string GetRandomPrompt()
    {
        // use the random method
        Random random = new Random();
        int i = random.Next(_promptList.Count);
        // return a random element from the promptList at the index i
        return _promptList[i];
    }
}
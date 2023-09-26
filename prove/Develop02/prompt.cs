using System;

public class Prompt
{
    private static List<string> promptList = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What have you done differently today?",
        "What is something unexpected that happened today?",
        "If you could change one thing from today, what would it be?",
        "List 3 things that helped you feel happy today.",
        "List 3 things you are grateful for.",
    };

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(promptList.Count);
        Console.WriteLine(promptList[i]);
    }
}
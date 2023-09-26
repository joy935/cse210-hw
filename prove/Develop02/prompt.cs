using System;

public class Prompt
{
    private static List<string> promptList = new List<string> 
    {
        "test1",
        "test2",
        "test3",
    };

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(promptList.Count);
        Console.WriteLine(promptList[i]);
    }
}
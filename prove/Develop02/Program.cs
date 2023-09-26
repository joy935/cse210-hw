using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal!");

        Prompt prompt = new Prompt();
        prompt.GetRandomPrompt();
    }
}
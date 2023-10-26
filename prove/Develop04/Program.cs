using System;

class Program
{
    static void Main(string[] args)
    {        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu.");
            string choiceUser = Console.ReadLine();
            int choice = int.Parse(choiceUser);

            if (choice == 1)
            {
                //Activity activity = new Activity("Breathing Activity", "This activity will help you relax and focus on your breathing.");
                //activity.DisplayStartMessage();
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax and focus on your breathing.");
                activity1.Duration = int.Parse(activity1.DisplayStartMessage());
                activity1.GetReady();
                activity1.DisplayBreathe();
                activity1.DisplayBreathe(); // define number of repetition based on duration
                activity1.DisplayEndMessage();
            }
            else if (choice == 2)
            {
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity2.Duration = int.Parse(activity2.DisplayStartMessage());
                activity2.GetReady();
                string ready = activity2.DisplayPrompt();
                if (string.IsNullOrWhiteSpace(ready))
                {
                    activity2.DisplayQuestion();
                    activity2.DisplayEndMessage();
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Starting listening activity...");
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }
}
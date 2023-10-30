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

            DateTime startTime = DateTime.Now;

            string choiceUser = Console.ReadLine();
            int choice = int.Parse(choiceUser);

            if (choice == 1)
            {
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax and focus on your breathing.");
                activity1.Duration = int.Parse(activity1.DisplayStartMessage());
                DateTime endTime = startTime.AddSeconds(activity1.Duration);
                DateTime currentTime = DateTime.Now;
                activity1.GetReady();
                do
                {
                    activity1.DisplayBreathe();
                }
                while (currentTime < endTime);
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
                    activity2.DisplayQuestion(); // define number of questions shown based on duration
                    activity2.DisplayEndMessage();
                }
            }
            else if (choice == 3)
            {
                ListeningActivity activity3 = new ListeningActivity("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity3.Duration = int.Parse(activity3.DisplayStartMessage());
                activity3.GetReady();
                activity3.DisplayPrompt();
                Console.WriteLine(activity3.GetResponse()); // define the time to write answers based on duration
                activity3.DisplayEndMessage();
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
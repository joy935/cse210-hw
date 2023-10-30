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
            Console.WriteLine("4. Start affirming activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice from the menu.");

            string choiceUser = Console.ReadLine();
            int choice = int.Parse(choiceUser);

            if (choice == 1)
            {
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax and focus on your breathing.", 0);
                activity1.Duration = int.Parse(activity1.DisplayStartMessage());

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity1.Duration);
                DateTime currentTime = DateTime.Now;

                activity1.GetReady();
                do
                {
                    activity1.DisplayBreathe();
                    currentTime = DateTime.Now;
                }
                while (currentTime < endTime);

                activity1.DisplayEndMessage();
                
            }
            else if (choice == 2)
            {
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                activity2.Duration = int.Parse(activity2.DisplayStartMessage());

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity2.Duration);
                DateTime currentTime = DateTime.Now;

                activity2.GetReady();
                string ready = activity2.DisplayPrompt();
                if (string.IsNullOrWhiteSpace(ready))
                {
                    Console.Clear();
                    do
                    {
                        activity2.DisplayQuestion();
                        currentTime = DateTime.Now;
                    }
                    while (currentTime < endTime);

                    activity2.DisplayEndMessage();
                }
            }
            else if (choice == 3)
            {
                ListingActivity activity3 = new ListingActivity("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                activity3.Duration = int.Parse(activity3.DisplayStartMessage());

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity3.Duration);
                DateTime currentTime = DateTime.Now;       

                activity3.GetReady();
                activity3.DisplayPrompt();
                int i = 0;
                do
                {
                    activity3.GetResponse();
                    i++;
                    currentTime = DateTime.Now; 
                }
                while (currentTime < endTime);
                Console.WriteLine($"You listed {i} items.");
                activity3.DisplayEndMessage();
            }
            else if (choice == 4)
            {
                AffirmingActivity activity4 = new AffirmingActivity("Affirming Activity", "This activity will help you to practice self affirmation to focus on yourself and your belief, which can increase self worth.", 0);
                activity4.Duration = int.Parse(activity4.DisplayStartMessage());

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity4.Duration);
                DateTime currentTime = DateTime.Now;

                activity4.GetReady();
                activity4.DisplayOpeningMessage();
                do
                {
                    activity4.DisplayAffirmation();
                    currentTime = DateTime.Now;
                }
                while (currentTime < endTime);
                activity4.DisplayEndMessage();
            }
            else if (choice == 5)
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
using System;

class Program
{
    static void Main(string[] args)
    {      
        // loop through the menu options until the user chooses to quit  
        while (true)
        {
            // clear the console
            Console.Clear();
            // display the menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start affirming activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice from the menu.");

            // get the user's choice
            string choiceUser = Console.ReadLine();
            // convert the user's choice to an integer
            int choice = int.Parse(choiceUser);

            // if the user chooses to start the breathing activity
            if (choice == 1)
            {
                // create a new instance of the BreathingActivity class
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax and focus on your breathing.", 0);
                // get the duration of the activity from the user
                activity1.Duration = int.Parse(activity1.DisplayStartMessage());

                // set the start time, end time, and current time
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity1.Duration);
                DateTime currentTime = DateTime.Now;

                // display the get ready message
                activity1.GetReady();
                // display the breathing activity until the end time is reached
                do
                {
                    activity1.DisplayBreathe();
                    // update the current time
                    currentTime = DateTime.Now;
                }
                while (currentTime < endTime);
                // display the end message
                activity1.DisplayEndMessage();
                
            }
            // if the user chooses to start the reflecting activity
            else if (choice == 2)
            {
                // create a new instance of the ReflectingActivity class
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                // get the duration of the activity from the user
                activity2.Duration = int.Parse(activity2.DisplayStartMessage());

                // set the start time, end time, and current time
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity2.Duration);
                DateTime currentTime = DateTime.Now;

                // display the get ready message
                activity2.GetReady();
                // display the prompt
                string ready = activity2.DisplayPrompt();
                // if the user is ready, display the question until the end time is reached
                if (string.IsNullOrWhiteSpace(ready))
                {
                    Console.Clear();
                    do
                    {
                        activity2.DisplayQuestion();
                        // update the current time
                        currentTime = DateTime.Now;
                    }
                    while (currentTime < endTime);
                    // display the end message
                    activity2.DisplayEndMessage();
                }
            }
            // if the user chooses to start the listing activity
            else if (choice == 3)
            {
                // create a new instance of the ListingActivity class
                ListingActivity activity3 = new ListingActivity("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                activity3.Duration = int.Parse(activity3.DisplayStartMessage());
                
                // set the start time, end time, and current time
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity3.Duration);
                DateTime currentTime = DateTime.Now;       

                // display the get ready message
                activity3.GetReady();
                // display the prompt
                activity3.DisplayPrompt();
                // create and initialize a counter variable
                int i = 0;
                // display the response until the end time is reached
                do
                {
                    activity3.GetResponse();
                    // increment the counter variable
                    i++;
                    // update the current time
                    currentTime = DateTime.Now; 
                }
                while (currentTime < endTime);
                // display the number of items listed
                Console.WriteLine($"You listed {i} items.");
                // display the end message
                activity3.DisplayEndMessage();
            }
            // if the user chooses to start the affirming activity
            else if (choice == 4)
            {
                // create a new instance of the AffirmingActivity class
                AffirmingActivity activity4 = new AffirmingActivity("Affirming Activity", "This activity will help you to practice self affirmation to focus on yourself and your belief, which can increase self worth.", 0);
                activity4.Duration = int.Parse(activity4.DisplayStartMessage());

                // set the start time, end time, and current time
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(activity4.Duration);
                DateTime currentTime = DateTime.Now;

                // display the get ready message
                activity4.GetReady();
                // display the opening message
                activity4.DisplayOpeningMessage();
                // display the affirmation until the end time is reached
                do
                {
                    activity4.DisplayAffirmation();
                    // update the current time
                    currentTime = DateTime.Now;
                }
                while (currentTime < endTime);
                // display the end message
                activity4.DisplayEndMessage();
            }
            // if the user chooses to quit
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
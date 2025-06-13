using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public void Run()
    {
        Start();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.WriteLine("You may begin in:");
        Countdown(5);

        Console.WriteLine("\nStart listing. Press Enter after each item:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.ReadLine();
                count++;
            }
        }

        Console.WriteLine($"\nYou listed {count} items.");
        End();
    }
}

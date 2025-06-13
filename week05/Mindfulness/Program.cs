using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();

        string input = "";
        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                var activity = new BreathingActivity();
                activity.Run();
            }
            else if (input == "2")
            {
                var activity = new ReflectionActivity();
                activity.Run();
            }
            else if (input == "3")
            {
                var activity = new ListingActivity();
                activity.Run();
            }
        }
    }
}


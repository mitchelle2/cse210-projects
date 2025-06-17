 using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        Console.WriteLine("Eternal Quest Tracker");

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoals(); break;
                case "3": manager.RecordGoal(); break;
                case "4": manager.SaveGoals(); break;
                case "5": manager.LoadGoals(); break;
                case "6": manager.ShowScore(); break;
                case "7": exit = true; break;
            }
        }
    }
}
// This Eternal Quest program exceeds the assignment requirements by:
// 1. Implementing a player leveling system: Users level up every 500 points.
// 2. Providing feedback on reaching new levels.
// 3. my program doesnt have a getdetailsstring but it does have a getstatus method that carries out similar functions



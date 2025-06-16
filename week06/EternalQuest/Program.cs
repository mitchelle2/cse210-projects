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

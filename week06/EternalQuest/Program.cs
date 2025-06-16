using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        Console.WriteLine("Eternal Quest Tracker");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine($"\nScore: {score}  (Level {score / 1000 + 1})");
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
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordGoal(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": ShowScore(); break;
                case "7": exit = true; break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type:\n1. Simple\n2. Eternal\n3. Checklist");
        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    static void RecordGoal()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetSaveData());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { });
                        if (bool.Parse(parts[4]))
                            goals[^1].RecordEvent(); // mark complete if saved as complete
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                            int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                        break;
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("No saved data found.");
        }
    }

    // Added this new method for option 6
    static void ShowScore()
    {
        Console.WriteLine($"\nCurrent Score: {score}  (Level {score / 500 + 1})");
    }
}
// This program exceeds the Eternal Quest assignment requirements by: 
// 1. Adding a leveling system (levels increase every 500 points). 

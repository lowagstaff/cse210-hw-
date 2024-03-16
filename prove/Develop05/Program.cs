using System;
using System.Drawing;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        List<string> file = new List<string>();
        string input = "";
        while (input != "6")
        {
            Goal g = new Goal();
            Console.WriteLine("Welcome to the Eternal Quest!");

            Console.WriteLine($"You have {totalPoints} points");

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            
            
            switch (input)
            {
                case "1":
                    Console.WriteLine("The types of goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string ginput =Console.ReadLine();
                    if (ginput == "1")
                    {
                        SimpleGoal s = new SimpleGoal();
                        s.StartSimpleGoal();
                        file.Add(s._saved);
                    }
                    else if (ginput == "2")
                    {
                        EternalGoal e = new EternalGoal();
                        e.StartEternalGoal();
                        file.Add(e._saved);
                    }
                    else if (ginput == "3")
                    {
                        ChecklistGoal c = new ChecklistGoal();
                        c.StartChecklist();
                        file.Add(c._saved);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please input a number either 1, 2, or 3.");
                    }
                    break;
                case "2":
                    foreach (string i in file)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case "3":
                    using (StreamWriter outputFile = new StreamWriter("goals.txt"))
                    {
                        foreach (string i in file)
                        {
                            outputFile.WriteLine(i);
                        }
                    }
                    break;
                case "4":
                    string[] lines = System.IO.File.ReadAllLines("goals.txt");
                    foreach (string line in lines)
                    {
                        file.Insert(0, line);
                    }
                    break;
                case "5":
                    Console.WriteLine("Which goal did you accomplish? (which goal number? ex. 1) ");
                    foreach (string i in file)
                    {
                        Console.WriteLine(i);
                    }
                    int goal = int.Parse(Console.ReadLine())-1;
                    string selection = file[goal];
                    string[] parts = selection.Split(",");
                    string points = parts[2];
                    Console.WriteLine($"Congratulations! You have earned {points}  points!");

                    totalPoints = totalPoints += int.Parse(points);
                    break;
            }
        }
    }
}
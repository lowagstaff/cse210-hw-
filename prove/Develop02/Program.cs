using System;
using System.IO.Enumeration;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO.Pipes;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string userChoice = "";

        while (userChoice != "5")
        {

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            Console.Write("> ");
    
            userChoice = Console.ReadLine();
    
            switch (userChoice)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    //TODO: save response to file

                    //Entry
                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;

                    //Journal
                    journal._entries.Add(entry);
                    break;
                case "2":
                    foreach(Entry submission in journal._entries)
                    {
                        Console.WriteLine($"{submission._entryDate} - {submission._prompt} - {submission._response}"); 
                    }
                    break;
                case "3":
                    LoadFromFile(journal);
                    break;
                case "4":
                    SaveToFile(journal._entries);
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    break;
            }

            static void SaveToFile(List<Entry> _entries)
            {
                Console.Write("What is the file name?\n> ");
                string fileName =Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._entryDate} - {entry._prompt} - {entry._response}");
                    }
                }
            }
            static void LoadFromFile(Journal journal)
            {
                Console.Write("What is the file name?\n> ");
                string loadName =Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(loadName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(" - ");
                    Entry entry = new Entry();
                    entry._entryDate = DateTime.Parse(parts[0]);
                    entry._prompt = parts[1];
                    entry._response = parts[2];
                    journal._entries.Add(entry);
                }

            }
        }
    }
}
using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture();
        Console.WriteLine(s.ReturnScripture());
        Console.Write("\nPress enter to continue or type 'quit' to exit\n>");
        string userInput = Console.ReadLine();
        Console.WriteLine("");

        Word w = new Word();
        
        while (userInput != "quit")
        {
            Console.WriteLine(w.RemoveChars());
            Console.Write("\nPress enter to continue or type 'quit' to exit\n>");
            userInput = Console.ReadLine(); 
        }
    }
}
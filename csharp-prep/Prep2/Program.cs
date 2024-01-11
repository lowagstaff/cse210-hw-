using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? %");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        if (grade >= 90)
        {
            //Console.WriteLine("Your grade is A");
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            //Console.WriteLine("Your grade is B");
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            //Console.WriteLine("Your grade is C");
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            //Console.WriteLine("Your grade is D");
            letter = "D";
        }
        else 
        {
            //Console.WriteLine("Your grade is F");
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass, you'll get it next time");
        }
        
    }
}
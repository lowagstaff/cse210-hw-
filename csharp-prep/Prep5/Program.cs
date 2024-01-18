using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string user = PromptUserName();
        int userNum = PromptUserNumber();

        int squared = SquareNumber(userNum);

        DisplayResult(user, squared);

    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program! ");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            return num;
        }
        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}
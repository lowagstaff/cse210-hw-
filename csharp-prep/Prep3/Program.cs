using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num1 = randomGenerator.Next(1,51);
        
        int num2 = -1; 

        while(num1 != num2)
        {
            Console.Write("What is your guess? 1-50 ");
            string input2 = Console.ReadLine();
            num2 = int.Parse(input2);

            if(num2 < num1)
            {
                Console.WriteLine("Higher");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}
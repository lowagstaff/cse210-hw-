using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int num0 = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finsihed");

        while (num0 != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            num0 = int.Parse(input);

            numbers.Add(num0);
        }
        
        int add = numbers.Sum();
        double ave = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {add}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The max is: {max}");




        
    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberGiven = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (numberGiven != 0)
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            numberGiven = int.Parse(numberString);

            if (numberGiven != 0)
            {
                numbers.Add(numberGiven);
            }
        }

        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The maximum is: {maximum}");

    }
}
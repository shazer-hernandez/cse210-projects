using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int numberVersion = int.Parse(grade);

        string letterGrade = "";

        if (numberVersion >= 90)
        {
            letterGrade = "A";
        }
        else if (numberVersion >= 80)
        {
            letterGrade = "B";
        }
        else if (numberVersion >= 70)
        {
            letterGrade = "C";
        }
        else if (numberVersion >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (numberVersion >= 70)
        {
            Console.Write("Congratulations! You passed!");
        }
        else 
        {
            Console.Write("You'll do better next time!");
        }
    }
}
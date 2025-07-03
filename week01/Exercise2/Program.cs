using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string Grade = Console.ReadLine();
        int percentage = int.Parse(Grade);

        string letter = "";
        string exception = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int LastDigit = percentage % 10;

        if (LastDigit >= 7)
        {
            exception = letter;
        }
        else
        {
            exception = letter;
            sign = "-";
            if (letter == "F")
            {
                exception = letter;
                sign = "";
            }
        }

        Console.WriteLine($"Your grade is {exception}{sign}");
    }
}
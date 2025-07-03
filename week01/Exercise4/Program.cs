using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int readNumber = -1;
        int sum = 0;
        int max = 0;
        int smallPositive = 999999;
        
        while (readNumber != 0)
        {
            Console.Write("Enter a number. ");
            readNumber = int.Parse(Console.ReadLine());

            if (readNumber != 0)
            {
                numbers.Add(readNumber);
            }

        }
        foreach ( int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }

            if (number < smallPositive && number > -1)
            {
                smallPositive = number;
            }
        }

        float average = ((float)sum) / numbers.Count;
        int sorted = numbers[numbers.Count - 1];



        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avarage}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is {smallPositive}");
        Console.WriteLine($"The sorted list is: {sorted}");
    }
}
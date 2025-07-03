using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult();
       
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Hello world!");
    }
    static string Username()
    {
        Console.Write($"Enter username: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int FavouriteNumber()
    {
        Console.Write($"Enter favourite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static void DisplayResult()
    {
        string userName = Username();
        int favNumber = FavouriteNumber();
        Console.WriteLine($"{userName}, the square of your number is {favNumber * favNumber}");
    }
}
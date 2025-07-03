using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        string playAgain = "yes";

       
       while ( playAgain.ToLower() == "yes")
       {

            int magicNumber = randomNumber.Next(1, 101);
            int guessNumber = -1;
            int guessCounter = 0;
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess?. ");
                guessNumber = int.Parse(Console.ReadLine());
                guessCounter++;

                if (guessNumber == magicNumber)
                {
                    Console.WriteLine("Correct");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("Invalid response");
                }
            }
            Console.WriteLine($" You guessed for {guessCounter} time(s)");
            Console.Write("Do you want to play again? yes/no ");
            playAgain = Console.ReadLine();
       }
    

    }
}
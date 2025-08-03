using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Victoria", "Biology");
        MathAssignment mathAssignment = new MathAssignment("5.6", "Reading problem", "Maria", "History");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Great Ocean", "Maria Coblabs", "Literature");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritinginformation());

    }
}
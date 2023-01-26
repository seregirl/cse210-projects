using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment = new MathAssignment("Section 7.3", "Problems 8-19", "Roberto Rodriguez",  "Fractions");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WritingAssignment writingassignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInformation());

    }
}
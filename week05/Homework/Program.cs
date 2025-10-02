using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignments assignments = new Assignments("Paul", "CSE210");
        Console.WriteLine($"\n{assignments.GetSummary()}");

        MathAssignment mathAssignment = new MathAssignment("Paul", "Shapes", "Chapter 11", "Circles");
        Console.WriteLine($"\n{mathAssignment.GetHomeworkList()}");

        WritingAssignments writingAssignments = new WritingAssignments("Paul", "Essay Writing", "Informal Letter");
        Console.WriteLine($"\n{writingAssignments.GetWritingInformation()}");  
    }
}
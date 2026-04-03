using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment task1 = new Assignment("Roberto Rodriguez", "Fractions");
        Console.WriteLine(task1.GetSummary());
        MathAssignment task2 = new MathAssignment("Samuel Bennett", "Multiplication", "Section 7.3", "Problems 8-19");
        Console.WriteLine($"{task2.GetSummary()}\n{task2.GetHomeworkList()}");
        WritingAssignment task3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"{task3.GetSummary()}\n{task3.GetWritingInformation()}");
    }   
}
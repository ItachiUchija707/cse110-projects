using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        string letter = "";
        Console.Write("What is your grade percentage? ");
        string user_grade= Console.ReadLine();
        int fGrade= int.Parse(user_grade);

        if (fGrade >= 90)
        {
          letter = "A"; 
        }

        else if (fGrade >= 80)
        {
          letter = "B";   
        }

        else if (fGrade >= 70)
        {
            letter = "C"; 
        }

        else if (fGrade >= 60)
        {
           letter = "D"; 
        }

        else
        {
           letter = "F";  
        }

        Console.WriteLine($"Your grade is {letter}");
        if (fGrade >= 70)
        {
            Console.WriteLine("You passed the course, congratulations!");
        }

        else
        {
            Console.WriteLine("You didn't pass the course, keep trying!");
        }
    }
}
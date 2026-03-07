using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName= PromptUserName();
        int userNumber = PromptUserNumber();
        int sNumber = SquareNumber(userNumber);
        DisplayResult(userName, sNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
       Console.Write("Please enter your name: ");
       string name = Console.ReadLine();
       return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int fNumber= int.Parse(number);
        return fNumber;
    }

    static int SquareNumber(int number)
    {
        int SquareNumber= number*number;
        return SquareNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}.");
    }
}
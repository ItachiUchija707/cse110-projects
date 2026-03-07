using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbersList = new List<int>();
        bool adding = true;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (adding)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            int fNumber = int.Parse(number);
            if (fNumber != 0)
            {
            numbersList.Add(fNumber);
            }
            else
            {
                adding = false;
            }
        }

        int max = 0;
        int total = 0;
        foreach (int number in numbersList)
        {   
            total+=number;
            if (number > max)
            {
                max= number;
            }
        }
        
        float average = total / numbersList.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
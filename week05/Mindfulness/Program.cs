using System;
// I showed creativity by keeping track of the questions asked to the user to avoid repeating same questions until they've been exhausted 
// by creating a second class variable _unusedQuestions that removes questions from itself as they are being asked. 
// Once all questions are asked, it refills again with questions from _questions
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool stayActive = true;

        while (stayActive)
        {
            Console.Clear();
            Console.WriteLine("------------Menu Options------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit Program");
            Console.WriteLine("Enter your selection: ");
            string userSelection = Console.ReadLine();
            

            if (userSelection == "1")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if (userSelection == "2")
            {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            else if (userSelection == "3")
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

            else if (userSelection == "4")
            {
                stayActive = false;
                Console.WriteLine("Thank you, come back soon!");
            }

            else
            {
                Console.WriteLine("Sorry, that's not a valid selection, please try again.");
                Thread.Sleep(2000);
            }
        }
       
    }
}
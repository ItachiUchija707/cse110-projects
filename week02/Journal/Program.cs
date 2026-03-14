using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Hello World! This is the Journal Project.");
        bool journaling = true;
        Journal theJournal = new Journal();
        PromptGenerator pg = new PromptGenerator();

        while (journaling)
        {
            Console.WriteLine("------------Menu Options----------------");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal from a file");
            Console.WriteLine("5. Quit");
            string userSelection = Console.ReadLine();

            if (userSelection == "1")
            {   
                List<string> responses = new List<string>();
                string prompt = pg.getRandomPrompt();
                Console.WriteLine(prompt);
                string promptResponse = Console.ReadLine();
                responses.Add(promptResponse);
                Console.Write("What is your mood on a scale 1-10? ");
                string mood = Console.ReadLine();
                responses.Add(mood);
                Console.Write("What are you grateful for so far today? ");
                string grateful = Console.ReadLine();
                responses.Add(grateful);
                Entry userResponses = new Entry(prompt, responses);
                theJournal.AddEntry(userResponses);
                Console.WriteLine();
            }

            else if (userSelection == "2")
            {
                theJournal.DisplayAll();
            }

            else if (userSelection == "3")
            {   
                Console.WriteLine("What file do you want to save it to? eg: journal.txt");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }

            else if (userSelection == "4")
            {
                Console.Write("From which file do you want to open your journal? ");
                string fileLoad = Console.ReadLine();
                theJournal.LoadFromFile(fileLoad);
                Console.WriteLine();
                theJournal.DisplayAll();
            }

            else if (userSelection == "5")
            {
                Console.WriteLine("Come back soon and have a great day!");
                journaling = false;
            }

            else
            {
                Console.WriteLine("Sorry that's not a valid selection, please try again");
            }
            
        }
    }
}
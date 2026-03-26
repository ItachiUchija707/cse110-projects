using System;
using System.Collections.Generic;

// I implemented a a list of scriptures that will be randomly pick up when the user runs the program. 
// The user will have the option to learn another scripture from the scripture list once previous scripture is fully hidden. 
class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Reference ref2 = new Reference("3 Nephi", 27, 27);
        Reference ref3 = new Reference("Ether", 2, 25);
        Reference ref4 = new Reference("Moroni", 9, 6);
        Scripture scriptureText1 = new Scripture(ref1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        Scripture scriptureText2 = new Scripture(ref2, "And know ye that ye shall be judges of this people, according to the judgment which I shall give unto you, which shall be just. Therefore, what manner of men ought ye to be? Verily I say unto you, even as I am.");
        Scripture scriptureText3 = new Scripture(ref3, "And behold, I prepare you against these things; for ye cannot cross this great deep save I prepare you against the waves of the sea, and the winds which have gone forth, and the floods which shall come. Therefore what will ye that I should prepare for you that ye may have light when ye are swallowed up in the depths of the sea?");
        Scripture scriptureText4 = new Scripture(ref4, "And now, my beloved son, notwithstanding their hardness, let us labor diligently; for if we should cease to labor, we should be brought under condemnation; for we have a labor to perform whilst in this tabernacle of clay, that we may conquer the enemy of all righteousness, and rest our souls in the kingdom of God.");
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(scriptureText1);
        scriptures.Add(scriptureText2);
        scriptures.Add(scriptureText3);
        scriptures.Add(scriptureText4);
        string userInput = "";
        bool memorize = true;

        Random randomScripture = new Random();
        int scriptureIndex = randomScripture.Next(scriptures.Count);


        while (memorize)
        {   
            Console.Clear();
            Console.WriteLine(scriptures[scriptureIndex].GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();

            if (!scriptures[scriptureIndex].IsCompletelyHidden() && userInput.ToLower() != "quit") 
            {
                scriptures[scriptureIndex].HideRandomWords(4);
            }
            
            else
            {
                if (scriptures[scriptureIndex].IsCompletelyHidden())
                {
                    Console.WriteLine("Congratulations, you've memorized an scripture!");
                    Console.WriteLine("Do you want to memorize another scripture?");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "yes")
                    {
                        scriptureIndex = randomScripture.Next(scriptures.Count);
                        memorize = true;
                        Console.Clear();
                    }

                    else
                    {
                        memorize = false;
                    }
                }
            }
        }

        Console.Clear();
        Console.WriteLine(scriptures[scriptureIndex].GetDisplayText());
    }
}
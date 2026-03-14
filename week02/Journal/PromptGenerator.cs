using System;
using System.Collections.Generic;
public class PromptGenerator
{
    List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?","What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?", "What am I grateful for today?", 
    "What did I learn today?", "What did I do today that I am proud of?", "What was the most challenging thing I faced today?"};
    Random _randomGenerator = new Random();
    
    public PromptGenerator()
    {
        
    }
    public string GetRandomPrompt()
    {
        int index = _randomGenerator.Next(_prompts.Count);
        string promptText = (_prompts[index]);
        return promptText;
    }
}
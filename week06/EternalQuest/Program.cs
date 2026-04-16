using System;
// For creativity I added a level up system so the user gets more excited about achieving goals and increase the gamification of the program
// the implentation of this level up system required the addition of methods and variables and some slight menu modifications. as well as 
// changing the behavior for saving and loading the files. 
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
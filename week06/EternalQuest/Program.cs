using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // - I put in a save and load feature that can handle all the different kinds of goals I made.
        //   It works by turning the goals into a string and then reading them back.
        // - Instead of putting all the logic in the main Program.cs file, I moved it into a
        //   separate GoalManager class to keep everything a lot cleaner.
        // - The GetDetailsString() method for each goal gives a really clear and detailed output,
        //   so it's easy for a user to see what's going on.

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the ScriptureMemorizer Project.");

        // This is for a library of Scriptures
        var scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son."
            ),
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want."
            ),
            // You can add more scriptures here
        };

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Good job!");
    }
}
// Optional Stretch - Exceeding Requirements
// I added support for multiple scriptures instead of just one.
// Now the program randomly picks one from a small library of scriptures each time it runs.
// This makes the program more helpful for practicing and memorizing different verses.
// I'm still learning, but I wanted to push myself a bit and go beyond the basics for this assignment.

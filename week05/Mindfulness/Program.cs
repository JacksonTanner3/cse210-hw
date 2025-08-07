using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        // - Included a simple menu system for user interactions.
        // - Made it so all common messages and animations (spinner, countdown) are handled by the base Activity class.
        // - Used Console.Clear() for a cleaner program between activities.
        // - Added a check in BreathingActivity to stop early if the time was met during the cycle.

        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                Activity currentActivity = null;

                switch (choice)
                {
                    case 1:
                        currentActivity = new BreathingActivity();
                        break;
                    case 2:
                        currentActivity = new ReflectionActivity();
                        break;
                    case 3:
                        currentActivity = new ListingActivity();
                        break;
                    case 4:
                        Console.WriteLine("\nThank you for practicing mindfulness. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
                        currentActivity = null;
                        break;
                }

                if (currentActivity != null)
                {
                    if (choice != 4)
                    {
                        currentActivity.RunActivity();
                    }
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a number.");
                choice = 0; // Reset to keep the loop going.
            }
            if (choice != 4)
            {
                Thread.Sleep(2000);
            }
        }
    }
}

using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void RunActivity()
    {
        DisplayStartingMessage();

        Console.WriteLine("Begin breathing cycle...");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4); // Breathe in for 4 seconds

            if ((DateTime.Now - startTime).TotalSeconds >= _duration) break;

            Console.Write("Breathe out...");
            ShowCountdown(6); // Breathe out for 6 seconds
        }

        DisplayEndingMessage();
    }
}

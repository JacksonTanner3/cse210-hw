using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int mNumber = int.Parse(magicNumber);

        // string guess = Console.ReadLine();
        // int gNumber = int.Parse(guess);

        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 100);
        
        int gNumber = -1;

        while (gNumber != mNumber)
        {
            Console.Write("What number do you guess? ");
            gNumber = int.Parse(Console.ReadLine());
            if (mNumber > gNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (mNumber < gNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
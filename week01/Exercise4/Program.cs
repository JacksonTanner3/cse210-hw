using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int uNumber = -1;
        while (uNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string uResponse = Console.ReadLine();
            uNumber = int.Parse(uResponse);

            if (uNumber != 0)
            {
                numbers.Add(uNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Second part
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");


        // Third Part
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The Max is: {max}");

    }
}
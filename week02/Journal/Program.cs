using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = -1;
        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        string date = DateTime.Now.ToString("yyyy-MM-dd");
                        Entry entry = new Entry(date, prompt, response);
                        journal.AddEntry(entry);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter filename to load: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        break;
                    case 4:
                        Console.Write("Enter filename to save: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
/*
EXCEEDING REQUIREMENTS:
This program will save and load in CSV-style format with commas and quotes taken care of.
This program will also allow files to be opened in Excel or other spreadsheet programs.
*/
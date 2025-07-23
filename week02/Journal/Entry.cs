using System;

public class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public string ToCsv()
    {
        return $"{Escape(Date)},{Escape(Prompt)},{Escape(Response)}";
    }

    public static Entry FromCsv(string line)
    {
        var values = SplitCsvLine(line);
        return new Entry(values[0], values[1], values[2]);
    }

    private string Escape(string text)
    {
        if (text.Contains(",") || text.Contains("\""))
        {
            text = text.Replace("\"", "\"\"");
            return $"\"{text}\"";
        }
        return text;
    }

    private static string[] SplitCsvLine(string line)
    {
        var result = new List<string>();
        bool inQuotes = false;
        string current = "";
        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];
            if (c == '"' && (i + 1 < line.Length && line[i + 1] == '"'))
            {
                current += '"';
                i++;
            }
            else if (c == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                result.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }
        result.Add(current);
        return result.ToArray();
    }
}

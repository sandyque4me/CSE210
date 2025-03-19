using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now });
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                // Save entries in CSV format (quote handling included)
                writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\"");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    entries.Add(new Entry
                    {
                        Date = DateTime.Parse(parts[0].Trim('"')),
                        Prompt = parts[1].Trim('"'),
                        Response = parts[2].Trim('"')
                    });
                }
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
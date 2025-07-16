using System;
using System.Collections.Generic;
using System.IO;

// On loadfromfile() function i created a check error if the file was not found
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry newEntry in _entries)
        {
            newEntry.Display();
        }
    }
    public void saveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry newEntry in _entries)
            {
                outputFile.WriteLine($"{newEntry._date}|{newEntry._prompText}|{newEntry._entryText}");
            }
        }
        Console.WriteLine($"Saved successfully to '{filename}' at: {Path.GetFullPath(filename)}");
    }

    public void loadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Error: The file '{filename}' does not exist.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry
            {
                _date = parts[0],
                _prompText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entry);
        }

        Console.WriteLine($"Loaded successfully from '{filename}");
    }


}
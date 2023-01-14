using System;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries) {
                    entry.Display();
                    Console.WriteLine();
                }
    }

    public void SaveEntries(string fileName)
    {


        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._prompt}~{entry._response}~{entry._date}");
            }
        }
    }

    public void LoadEntries(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            Entry entry = new Entry();
            entry._prompt = parts[0];
            entry._response = parts[1];
            entry._date = parts[2];
            _entries.Add(entry);
        }
    }

}
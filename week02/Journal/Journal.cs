using System.IO;
using System.Text.Json;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter filename: ");
        string filename = $"{Console.ReadLine()}";

        string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, jsonString);

        Console.WriteLine("Journal Entries Saved!");
    }
    public void LoadFromFile()
    {
        Console.Write("Enter filename: ");
        string filename = $"{Console.ReadLine()}";

        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            Console.WriteLine("Journal Entries Loaded!");
        }
        else
        {
            Console.WriteLine($"File: {filename} doesnt exist. You might have mispelled or put wrong file extension.");
        }
    }



}
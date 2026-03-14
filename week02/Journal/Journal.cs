using System.IO;

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

    public void SaveToFile(string filename)
    {
        using (StreamWriter fileWriter = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                fileWriter.WriteLine($"{entry._date}|{entry._randomPrompt}|{entry._userEntry[0]}|{entry._userEntry[1]}|{entry._userEntry[2]}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            List<string> responses = new List<string>();
            responses.Add(parts[2]);
            responses.Add(parts[3]);
            responses.Add(parts[4]);
            Entry newEntry = new Entry(parts[1], responses);
            newEntry._date = parts[0];
            _entries.Add(newEntry);
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


}
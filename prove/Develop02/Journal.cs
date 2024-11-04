public class Journal
// work done by al members of group!
{
    private List<Entry> _entries = new List<Entry>(); // List to store journal entries

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine("Prompt: " + entry.PromptText);
            Console.WriteLine("Entry: " + entry.EntryText);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
{
    try
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine("Date: " + entry.Date);
                writer.WriteLine("Prompt: " + entry.PromptText);
                writer.WriteLine("Entry: " + entry.EntryText);
                writer.WriteLine(); // Add an empty line between entries
            }
        }

        Console.WriteLine("Journal saved to " + fileName);
    }
    catch (Exception e)
    {
        Console.WriteLine("Error saving journal: " + e.Message);
    }
}

    public void LoadFromFile(string fileName)
{
    try
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            Entry currentEntry = null;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date: "))
                {
                    currentEntry = new Entry();
                    currentEntry.Date = line.Substring(6); // Extract date value
                }
                else if (line.StartsWith("Prompt: "))
                {
                    if (currentEntry != null)
                    {
                        currentEntry.PromptText = line.Substring(8); // Extract prompt text
                    }
                }
                else if (line.StartsWith("Entry: "))
                {
                    if (currentEntry != null)
                    {
                        currentEntry.EntryText = line.Substring(7); // Extract entry text
                        _entries.Add(currentEntry); // Add the entry to the list
                        currentEntry = null; // Reset currentEntry
                    }
                }
            }
        }

        Console.WriteLine("Journal loaded from " + fileName);
    }
    catch (Exception e)
    {
        Console.WriteLine("Error loading journal: " + e.Message);
    }
}
    
}

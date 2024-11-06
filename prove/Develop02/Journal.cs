public class Journal
// work done by al members of group!
{
    private List<Entry> _entries = new List<Entry>(); // List to store journal entries

    public void AddEntry() 
    {   Entry newEntry = new 
        Entry(); 
        newEntry.GetDateTime(); 
        newEntry.GetPrompt(); 
        Console.Write("Response: "); 
        newEntry.GetResponse();
         _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("Date: " + entry._timestamp);
            Console.WriteLine("Prompt: " + entry._prompt);
            Console.WriteLine("Entry: " + entry._body);
            Console.WriteLine();
        }
    
    }
    public void DisplayEntries() 
    { foreach (Entry entry in _entries) 
    {   Console.WriteLine("Date: " + entry._timestamp);
        Console.WriteLine("Prompt: " + entry._prompt);  
        Console.WriteLine("Entry: " + entry._body); 
        Console.WriteLine(); 
        } 
    }

    public void SaveFile() 
    { Console.Write("Enter filename to save: "); 
    string fileName = Console.ReadLine(); 
        try 
        {   using  
            (StreamWriter writer = new StreamWriter(fileName)) 
            { 
                foreach 
                    (Entry entry in _entries) 
                {   
                    writer.WriteLine("Date: " + entry._timestamp); 
                    writer.WriteLine("Prompt: " + entry._prompt); 
                    writer.WriteLine("Entry: " + entry._body); 
                    writer.WriteLine(); 
                }
            }  
             Console.WriteLine("Journal saved to " + fileName); 
            } 
                catch (Exception e) 
                { 
                    Console.WriteLine("Error saving journal: " + e.Message); 
                } 
    }
     public void LoadFile() 
    {   Console.Write("Enter filename to load: "); 
        string fileName = Console.ReadLine();  
        try 
            { 
                using (StreamReader reader = new StreamReader(fileName)) 
                { 
                    string line; Entry currentEntry = null; while ((line = reader.ReadLine()) != null) 
                    { 
                        if (line.StartsWith("Date: ")) 
                        { 
                            currentEntry = new Entry(); 
                            currentEntry._timestamp = line.Substring(6); 
                            } 
                            else if (line.StartsWith("Prompt: ")) 
                            { 
                                if (currentEntry != null) 
                                { 
                                    currentEntry._prompt = line.Substring(8); 
                                } 
                            } 
                            else if (line.StartsWith("Entry: ")) 
                                { 
                                    if (currentEntry != null) 
                                { 
                                    currentEntry._body = line.Substring(7); 
                                _entries.Add(currentEntry); 
                                currentEntry = null;} 
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
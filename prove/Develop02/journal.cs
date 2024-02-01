using System;
using System.IO;

public class Journal
{
    // Attributes / Variable
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {  // Constructor
    }

    public void LoadFromFile(string fileName)
    {
        // Saving to file
	
	    string[] lines = System.IO.File.ReadAllLines(fileName);

	    foreach (string line in lines)
	    {
		    string[] parts = line.Split("|");
		    Entry fileEntry = new Entry();

		    fileEntry._promptText = parts[0];
		    fileEntry._date = parts[1];
		    fileEntry._entryText = parts[2];

		    AddEntry(fileEntry);
	    }
	
    }

    public void SaveToFile(string fileName)
    {
        // Loading from file
	    using (StreamWriter outputFile = new StreamWriter(fileName))
	    {
	    	if (_entries.Count > 0)
	    	{
	    		foreach (Entry en in _entries)
	    		{
	    			outputFile.WriteLine($"{en._promptText}|{en._date}|{en._entryText}");
	    		}
	    	}
	    }
    }

    public void AddEntry(Entry newEntry)
    {
        // Adding an entry
	    _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Displaying all infos
	    if (_entries.Count > 0)
	    {
		    foreach (Entry en in _entries)
		    {
		    	en.Display();
		    }
	    }
	    else
	    {
	    	Console.WriteLine("No Entry has been made\n");
	    }
    }
}
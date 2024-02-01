using System;

public class Entry
{
	// Class Attributes
	public string _entryText; // Saved entry texts
	public string _date; // Current date of input
	public string _promptText; // prompt generated
	PromptGenerator _prompt_generator = new PromptGenerator();
	DateTime theCurrentTime = DateTime.Now;


	public Entry()
	{
		// Constructor

		// Getting the random prompt messages
		_promptText = _prompt_generator.GetRandomPrompt();

		// Getting Date
		_date = theCurrentTime.ToShortDateString();

		_entryText = "";
	}
	
	public void Display()
	{
		Console.WriteLine($"{_promptText}");
		Console.WriteLine($"----------------------------------------");
		Console.WriteLine($"{_date}");
		Console.WriteLine($"----------------------------------------\n");
		Console.WriteLine($"Entry:");
		Console.WriteLine($"{_entryText}\n\n");
	}

}



























































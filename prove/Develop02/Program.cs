using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
		Journal journalName = new Journal();
		string filename = "";

		while (true)
		{
			string option;

			Console.WriteLine("Select an entry (1-5):\n");

			Console.WriteLine("1. New entry");
			Console.WriteLine("2. Display");
			Console.WriteLine("3. Save");
			Console.WriteLine("4. Load");
			Console.WriteLine("5. Exit");

			option = Console.ReadLine();

			switch (option)
			{
				case "1":
					WriteEntry(journalName);
					break;
				case "2":
					journalName.DisplayAll();
					break;
				case "3":
					SaveEntriesToFile(journalName, filename);
					break;
				case "4":
					LoadEntriesFromFile(journalName, filename);
					break;
				case "5":
					return;
				default:
					Console.WriteLine("\nInvalid option");
					break;
			}
		}
	}

	static void WriteEntry(Journal journalName)
	{
		Entry new_entry = new Entry();

		Console.WriteLine("Enter your entry below (Press Return/Enter to end)\n");

		new_entry._entryText = Console.ReadLine();

		journalName.AddEntry(new_entry);
	}

	static void SaveEntriesToFile(Journal journalName, string fileName)
	{
		if (fileName == "")
		{
			Console.Write("Enter your filename (without an extension): ");
			fileName = Console.ReadLine();
			fileName += ".txt";
		}
		
		journalName.SaveToFile(fileName);
	}

	static void LoadEntriesFromFile(Journal journalName, string fileName)
	{
		if (fileName == "")
		{
			Console.Write("Enter your filename: ");

			fileName = Console.ReadLine();
		}

		journalName.LoadFromFile(fileName);
	}
}
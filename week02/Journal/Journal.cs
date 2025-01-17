public class Journal
{
    public List<Entry> _entries = new();

    public void CreateNewEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Write the text of your entry as a single string: ");
        string entryText = Console.ReadLine();
        Entry entry = new(prompt, entryText);
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            Console.WriteLine("Your recent entries:");
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string userName)
    {
        string projectDirectory = Directory.GetCurrentDirectory();
        string folderPath = Path.Combine(projectDirectory, "Journals");
        Directory.CreateDirectory(folderPath);

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string file = $"{userName}_{date}.txt";
        string filePath = Path.Combine(folderPath, file);

        string content = string.Join(Environment.NewLine, _entries.Select(e => e.ToString()));
        File.WriteAllText(filePath, content);

        Console.WriteLine($"Journal saved to {filePath}");
    }

    public void LoadFromFile()
    {
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Journals");

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("No journals found. The directory does not exist.");
            return;
        }

        string[] journalFiles = Directory.GetFiles(folderPath, "*.txt");

        if (journalFiles.Length == 0)
        {
            Console.WriteLine("No journals found in the directory.");
            return;
        }

        Console.WriteLine("Available journals:");
        for (int i = 0; i < journalFiles.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(journalFiles[i])}");
        }

        Console.WriteLine("Enter the number of the journal you'd like to load:");
        if (int.TryParse(Console.ReadLine(), out int selectedIndex) &&
            selectedIndex > 0 &&
            selectedIndex <= journalFiles.Length)
        {
            string selectedFile = journalFiles[selectedIndex - 1];
            string content = File.ReadAllText(selectedFile);

            Console.WriteLine($"\nContents of {Path.GetFileName(selectedFile)}:\n");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("Invalid selection. Returning to the menu.");
        }
    }
}
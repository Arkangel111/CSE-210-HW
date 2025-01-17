using System.Net.Mail;

public class Journal
{
    public List<Entry> _entries = new();
    public void CreateNewEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Write the text of your entry as a single string.");
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
            for (int i = 0; i < _entries.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_entries[i]}");
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
        string content = string.Join(Environment.NewLine, _entries);
        File.WriteAllText(filePath, content);

        Console.WriteLine($"Journal saved to {filePath}");
    }

    public void LoadFromFile(string file)
    {
        string folderpath = Path.Combine(Directory.GetCurrentDirectory(), "Journals");
        if (!Directory.Exists(folderpath))
        {
            Console.WriteLine("No Journals found. The Directory does not exist.")
            return;
        }
        string[] journalFiles = Directory.GetFiles(folderpath, "*.txt");

        if (journalFiles.Length == 0)
        {
            Console.WriteLine("no Journals found in the directory");
            return;
        }
        Console.WriteLine("Available journals: ");
        for (int i = 0; i < journalFiles.Length; i++)
        {
            string file = Path.GetFileName(journalFiles[i]);
            Console.WriteLine($"{i + 1}. {file}");

            Console.WriteLine("enter the file number you wish to load:");
            int selectedIndex = int.Console.ReadLine();
            string selectedFile = journalFiles[selectedIndex - 1];

            string content = File.ReadAllText(selectedFile);
            Console.WriteLine(content);
        }
    }
}
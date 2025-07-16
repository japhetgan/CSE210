using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program");

        List<string> menuItems = new List<string>
        {
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
        };

        void DisplayMenu()
        {
            foreach (string menuItem in menuItems)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("What do you like to do?");
        }

        DisplayMenu();

        string intitialSelected = Console.ReadLine().Trim();
        string selected = intitialSelected;

        while (selected != "5")
        {
            switch (selected)
            {
                case "1":

                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    string entryText = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;

                    Entry entry = new Entry();
                    entry.Date = theCurrentTime.ToString();
                    entry.PromptText = promptText;
                    entry.EntryText = entryText;
                    journal._entries.Add(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.LoadFromFile();
                    break;
                case "4":
                    journal.SaveToFile();
                    break;
                default:
                    Console.WriteLine($"\"{selected}\" is not on the list, please try again");
                    break;
            }
            DisplayMenu();
            selected = Console.ReadLine().Trim();
       }
    }
}
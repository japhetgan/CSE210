using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Before we begin, please choose your difficulty level:");
        Console.WriteLine("1 - Easy (hide 1 word at a time)");
        Console.WriteLine("2 - Medium (hide 3 words at a time)");
        Console.WriteLine("3 - Hard (hide 5 words at a time)");
        Console.Write("Enter the number of your choice: ");
        string input = Console.ReadLine();

        int difficulty = 0;

        while (difficulty == 0) {
            switch (input) {
                case "1":
                    difficulty = 1;
                    break;
                case "2":
                    difficulty = 3;
                    break;
                case "3":
                    difficulty = 5;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    input = Console.ReadLine();
                    break;
            }
        }

        bool quit = false;

        while (!quit && !scripture.isCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string response = Console.ReadLine();

            if (response == "")
            {
                Console.Clear();
                scripture.HideRandomWords(difficulty);
            }
            else
            {
                quit = true;
            }
        }
    }
}
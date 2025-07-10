using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();

        Console.Write("Please enter your favorite number: ");
        string favNum = Console.ReadLine();
        int favNumInt = int.Parse(favNum);

        int squared = SquareNumber(favNumInt);

        DisplayResult(name, squared);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squared) {
         Console.WriteLine($"Brother {name}, the square of your number is {squared}");
    }


}
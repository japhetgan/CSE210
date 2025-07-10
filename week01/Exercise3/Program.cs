using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        bool isGuessed = false;

        while (!isGuessed)
        {
            Console.Write("Guess a number between 1 and 100: ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                isGuessed = true;
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}
using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        bool IsZero = false;

        while (!IsZero)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                IsZero = true;
            }
            else
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int largest = 0;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
            sum += number;
        }

        float average = (float) sum / numbers.Count();
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
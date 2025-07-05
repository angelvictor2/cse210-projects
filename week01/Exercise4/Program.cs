using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int new_number = -1;

        while (new_number != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string user_input = Console.ReadLine();
            new_number = int.Parse(user_input);

            if (new_number != 0)
            {
                numbers.Add(new_number);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average is: {average}");

        int max = -1;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");


    }
}
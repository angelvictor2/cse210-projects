using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = squareNumber(number);
        DisplayResult(username, squaredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello Class Cs210");
    }

    static string PromptUserName()
    {
        Console.Write("Please introduce your name ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please introduce your favorite number ");
        int favorite_number = int.Parse(Console.ReadLine());

        return favorite_number;
    }

    static int squareNumber(int favorite_number)
    {
        int square = favorite_number * favorite_number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
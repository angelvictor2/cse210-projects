using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please introduce your grade percentage: ");
        string user_input = Console.ReadLine();
        int grade = int.Parse(user_input);

        string bowel = "";

        if (grade > 90)
        {
            bowel = "A";
        }

        else if (grade > 80)
        {
            bowel = "B";
        }

        else if (grade > 70)
        {
            bowel = "C";
        }

        else if (grade > 60)
        {
            bowel = "D";
        }

        else
        {
            bowel = "F";
        }

        Console.WriteLine($"Your grade score is: {bowel}");

        if (grade > 60)
        {
            Console.WriteLine("Congratulations you passed");
        }

        else
        {
            Console.WriteLine("Sorry, You failed this course");
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Jhon", 14, 6, 20);
        String verse = "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.";
        Scripture scripture = new Scripture(reference1, verse);

        string user_entry = "";


        while (user_entry != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Please enter to continue or type quit to finish: ");
            user_entry = Console.ReadLine();

            if (user_entry != "quit")
            {
                scripture.HideRandomWords();
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden or program exited. Goodbye!");
    }
}
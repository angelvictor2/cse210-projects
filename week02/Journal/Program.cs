using System;
using System.Reflection.Metadata;


// On loadfromfile() function i created a check error if the file was not found
// on main file i created an error message if not being put correct number selection.
class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int userentry = -1;
        while (userentry != 5)
        {
            Console.WriteLine("Welcome to daily Journal.");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save file");
            Console.WriteLine("4. Load the Journal");
            Console.WriteLine("5. Quit");

            Console.Write("Introduce option that you would like to take: ");
            string user_input = Console.ReadLine();
            userentry = int.Parse(user_input);

            if (userentry == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd"),
                    _prompText = prompt,
                    _entryText = response
                };
                myJournal.AddEntry(newEntry);
            }

            else if (userentry == 2)
            {
                myJournal.DisplayAll();
            }

            else if (userentry == 3)
            {
                Console.WriteLine("What is the filename");
                string filename = Console.ReadLine();
                myJournal.saveToFile(filename);
            }

            else if (userentry == 4)
            {
                Console.WriteLine("What is the filename you want to load from: ");
                string filename = Console.ReadLine();
                myJournal.loadFromFile(filename);
            }

            else
            {
                Console.WriteLine("Please enter a valid number option");
            }
        }

        Console.WriteLine("Thank you! See you soon");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 11);


        int guess_number = -1;

        while (magic_number != guess_number)
        {
            Console.Write("What is the guess number: ");
            guess_number = int.Parse(Console.ReadLine());


            if (magic_number < guess_number)
            {
                Console.WriteLine("Please try again you need to get a number lower!");

            }

            else if (magic_number > guess_number)
            {
                Console.WriteLine("Please try again you need to get a number higher!");
            }

            else
            {
                Console.WriteLine("Congratulations, you guessed it!");
            }
        }
        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment1 = new Assigment("Angel Victor", "Mathematics");
        Console.WriteLine(assigment1.GetSummary());


        MathAssignment mathAssignment1 = new MathAssignment("Angel Victor", "Math", "Chapter3", "8-20");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeWorkList());

        WrittingAssignment wrriting1 = new WrittingAssignment("Angel Victor", "Math", "Numbers");
        Console.WriteLine(wrriting1.GetSummary());
        Console.WriteLine(wrriting1.GetWritingInformation());
    }
}
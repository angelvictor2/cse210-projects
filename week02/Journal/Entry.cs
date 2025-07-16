
public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;

    public void Display()
    {
        Console.Write($"Date: {_date}  ");
        Console.WriteLine($"Prompt given: {_prompText}");
        Console.WriteLine($"Your Response had been: {_entryText}");
        Console.WriteLine();

    }
}
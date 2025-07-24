
using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] eachword = text.Split();

        foreach (string word in eachword)
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords()
    {
        Random _random = new Random();
        int wordsTohide = 2;
        int attempts = 0;

        while (wordsTohide > 0)
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsTohide--;
            }

            attempts++;
        }
    }
    

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return _reference.GetDisplayText() + " " + string.Join(" ", displayWords);
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
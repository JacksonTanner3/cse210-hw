using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int attempts = 0;
        int hidden = 0;

        while (hidden < numberToHide && attempts < 100)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
            attempts++;
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }

        return display.Trim();
    }

    public bool AllWordsHidden()
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

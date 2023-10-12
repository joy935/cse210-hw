using System;

public class Word
{
    private string _word;

    public string HideWord()
    {
        return "______";
    }

    public string ShowWord()
    {
        return $"{_word}";
    }

    public bool IsHidden()
    {
        if (_word.Contains("______"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetRenderedText()
    {
        return $"{_word}";
    }

    public Word(string word)
    {
        _word = word;
    }
}
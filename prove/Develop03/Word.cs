using System;

public class Word
{
    private string _word;

    public string HideWord()
    {
        int length = _word.Length;
        //_word = _word.Replace(_word, "_");
        foreach (char letter in _word)
        {
            letter = "_";
        }
        return _word;
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
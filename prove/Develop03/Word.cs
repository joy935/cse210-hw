using System;

public class Word
{
    private string _word;

    public string HideWord()
    {
        int length = _word.Length;
        _word = _word.Replace(_word, "_");
        return _word;
    }

    public string ShowWord()
    {
        return $"{_word}";
    }

    public bool IsHidden(string word)
    {
        if (word.Contains("______"))
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
        if (IsHidden(_word) == true)
        {
            return HideWord();
        }
        else
        {
            return ShowWord();
        }
    }

    public Word(string word)
    {
        // accept the text of the word to save it as an attribute
        word = _word;
        // set the initial visibility of the word
        HideWord();
    }
}
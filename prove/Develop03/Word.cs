using System;

public class Word
{
    private string _word;

    public string HideWord()
    {
        if (_word == null)
        {
            return "No word to hide.";
        }
        else
        {
            int length = _word.Length;
            foreach (char letter in _word)
            {
                _word = _word.Replace(letter, '_');
            }
            return _word;
        }
    }

    public string ShowWord()
    {
        return $"{_word}";
    }

    public bool IsHidden()
    {
        if (_word == null)
        {
            return false;
        }
        else
        {
            if (_word.Contains("_"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public string GetRenderedText()
    {
        if (IsHidden() == true)
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
        _word = word;
        // set the initial visibility of the word
        ShowWord();
    }
}
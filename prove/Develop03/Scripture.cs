using System;

public class Scripture
{
    private string _reference;
    private string _text;

    public string HideWords()
    {
        string[] words = _text.Split(' ');
        Random random = new Random();
        int randomIndex = random.Next(0, words.Length);
        words[randomIndex] = "______";
        _text = string.Join(" ", words);
        return _text;
    }

    public string GetRenderedText()
    {
        return $"{_reference} {_text}";
    }

    public string IsCompletelyHidden()
    {
        if (_text.Contains("______"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }
}
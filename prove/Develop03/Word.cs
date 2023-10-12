using System;

public class Word
{
    private string _word;

    public void HideWord()
    {

    };

    public void ShowWord()
    {

    };

    public void IsHidden()
    {

    };

    public string GetRenderedText()
    {
        return $"{_word}";
    };

    public Word(string word)
    {
        _word = word;
    };
}
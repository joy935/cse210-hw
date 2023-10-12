using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseEnd;
    private string _text;

    public string GetReference()
    {
        _book = "John";
        _chapter = "3";
        _verse = "16";
        return $"{_book} {_chapter}:{_verse}";
    }
    public void SetReference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public string GetText()
    {
        _text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        return $"{_text}";
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public Reference(string verse)
    {
        _verse = verse;
    }

    public Reference(string verse, string verseEnd)
    {
        _verse = verse;
        _verseEnd = verseEnd;
    }
}
using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseEnd;
    private string _text;

    public string DisplayReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public string DisplayText()
    {
        return $"{_text}";
    }

    public Reference()
    {
        _book = "John";
        _chapter = "3";
        _verse = "16";
        _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
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
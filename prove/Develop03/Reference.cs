using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseEnd;

    public string GetReference()
    {
        if (!string.IsNullOrEmpty(_verseEnd))
    {
        return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
    }
        else
    {
        return $"{_book} {_chapter}:{_verse}";
    }
    }

    public Reference(string book, string chapter, string verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }
    public Reference(string book, string chapter, string verse, string verseEnd)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._verseEnd = verseEnd;
    }
}
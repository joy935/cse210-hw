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
        return $"{_book} {_chapter}:{_verse}";
    }
    public void SetReference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public string GetReferenceMultipleVerses()
    {
        return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
    }
    public void SetReferenceMutipleVerses(string book, string chapter, string verse, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verseEnd;
    }
    public string GetText()
    {
        return $"{_text}";
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public Reference(string verse)
    {
        GetReference();
        GetText();
    }
    public Reference(string verse, string verseEnd)
    {
        GetReferenceMultipleVerses();
        GetText();
    }
}
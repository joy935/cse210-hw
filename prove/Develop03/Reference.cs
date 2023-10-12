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
        return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
    };

    public string DisplayText()
    {
        return $"{_text}";
    };

    public Reference(string verse)
    {
        _verse = verse;
    }
    public Reference(string verse, string verseEnd)
    {
        _verse = verse;
        _verseEnd = verseEnd;
    };

}
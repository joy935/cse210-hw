using System;

// Reference class
public class Reference
{
    // private attributes
    private string _book;       // the book of the reference
    private string _chapter;    // the chapter of the reference
    private string _verse;      // the verse of the reference
    private string _verseEnd;   // the ending verse of the reference

    /* GetReference is a method that returns a string of the reference
    Parameters: none
    Return: string, the reference 
    */
    public string GetReference()
    {
        // if there is a verseEnd, return the reference with the verseEnd
        if (!string.IsNullOrEmpty(_verseEnd))
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }
        // if there is no verseEnd, return the reference without the verseEnd
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

    /* Reference is a constructor that takes in a book, chapter, and verse
    and initializes the private attributes
    Parameters: string book, string chapter, string verse
    Return: none 
    */
    public Reference(string book, string chapter, string verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    /* Reference is another constructor that takes in a book, chapter, verse, 
    and verseEnd and initializes the private attributes
    Parameters: string book, string chapter, string verse, string verseEnd
    Return: none */
    public Reference(string book, string chapter, string verse, string verseEnd)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._verseEnd = verseEnd;
    }
}
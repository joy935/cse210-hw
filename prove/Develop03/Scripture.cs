using System;

public class Scripture
{
    private Reference reference;
    private string _text;
    private List<Word> wordObjects; 

    public string HideWords()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, wordObjects.Count);
        wordObjects[randomIndex].HideWord();
        return wordObjects[randomIndex].GetText();
    }

    public string GetRenderedText()
    {
        return $"{reference.GetRenderedText()} {_text}";
    }

    public bool IsCompletelyHidden()
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

    public Scripture(string book, string chapter, string verse, string text)
    {
        reference = new Reference(book, chapter, verse);
        this._text = text;

        // create a list from the text and split up the words
        List<string> wordList = text.Split(" ").ToList();

        // // create a list of Word objects
        List<Word> wordObjects = new List<Word>();

        // split up the words into strings to create Word objects
        foreach (string word in wordList)
        {
            Word oneWord = new Word(word);
            wordObjects.Add(oneWord);
            // wordObjects.Add(oneWord);
        }
    }
    public Scripture(string book, string chapter, string verse, string verseEnd, string text)
    {
        reference = new Reference(book, chapter, verse, verseEnd);
        this._text = text;
    }
    public Reference Reference
    {
        get { return reference; }
        set { reference = value; }
    }
    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }
}
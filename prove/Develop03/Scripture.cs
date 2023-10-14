using System;

public class Scripture
{
    private string _reference;
    private string _text;

    public string HideWords()
    {


        
        // string[] words = _text.Split(' ');
        // Random random = new Random();
        // int randomIndex = random.Next(0, words.Length);
        // words[randomIndex] = "______";
        // _text = string.Join(" ", words);
        // return _text;
    }

    public string GetRenderedText()
    {
        return $"{_reference} {_text}";
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

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;

        // create a list from the text and split up the words
        List<string> wordList = text.Split(" ").ToList();

        // // create a list of Word objects
        // List<Word> wordObjects = new List<Word>();

        // split up the words into strings to create Word objects
        foreach (string word in wordList)
        {
            Word oneWord = new Word(word);
            wordList.Add(oneWord);
            // wordObjects.Add(oneWord);
        }
    }
}
using System;

// Scripture class
public class Scripture
{
    // private attributes
    private Reference reference;        // the constructor from the Reference class
    private string _text;               // the text of the scripture
    private List<Word> wordObjects;     // the list of Word objects

    /* HideWords is a method that hides a random word in the scripture 
    and returns the text with the word hidden
    Parameter: none
    Return: string, the text with a word hidden or shown
    */
    public string HideWords()
    {
        // create a random number generator
        Random random = new Random();
        // initialize the previous index to -1
        int previousIndex = -1;
        // create a random index in the scope of the wordObjects
        int randomIndex = random.Next(0, wordObjects.Count);

        /* loop through the randomIndex until it is not 
        the same as the previous index */
        do 
        {
            randomIndex = random.Next(0, wordObjects.Count);
        } while (randomIndex == previousIndex);
        
        // loop through the wordObjects
        for (int i = 0; i < wordObjects.Count; i++)
        {
            // if the index is the random index
            if (i == randomIndex)
            {
                // hide the word
                wordObjects[i].HideWord();
            }
            // if the index is not the random index
            else
            {
                // show the word
                wordObjects[i].ShowWord();
            }
        }
        // update the text with the word hidden or shown
        _text = string.Join(" ", wordObjects.Select(word => word.GetRenderedText()));
        // return the text with the word hidden
        return _text;
    }

    /* GetRenderedText is a method that returns the text with the reference
    Parameter: none
    Return: string, the text with the reference
    */
    public string GetRenderedText()
    {
        return $"{reference.GetReference()} {_text}";
    }

    /* IsCompletelyHidden is a method that checks if all the words are hidden
    Parameter: none
    Return: bool, true if all the words are hidden, false if not
    */
    public bool IsCompletelyHidden()
    {
        return (wordObjects.All(word => word.IsHidden()));
    }

    /* Scripture is a constructor for the Scripture class that
    takes in a book, chapter, verse, and text and initializes the 
    private attributes. It also creates a list of Word objects 
    from the text and splits up the words.
    Parameter: strings, the book, the chapter, the verse and the text
    Return: none
    */
    public Scripture(string book, string chapter, string verse, string text)
    {
        // create a new reference object
        reference = new Reference(book, chapter, verse);
        // set the text
        this._text = text;

        // create a list from the text and split up the words
        List<string> wordList = text.Split(" ").ToList();

        // create a list of Word objects
        wordObjects = new List<Word>();

        // split up the words into strings to create Word objects
        foreach (string word in wordList)
        {
            Word oneWord = new Word(word);
            wordObjects.Add(oneWord);
        }
    }

    /* Scripture is another constructor for the Scripture class that takes in 
    a book, chapter, verse, verseEnd, and text and initializes the private
    attributes. It also creates a list of Word objects from the text and
    splits up the words.
    Parameter: strings, the book, the chapter, the verse, the verseEnd and the text
    Return: none
    */
    public Scripture(string book, string chapter, string verse, string verseEnd, string text)
    {
        // create a new reference object
        reference = new Reference(book, chapter, verse, verseEnd);
        // set the text
        this._text = text;

        // create a list from the text and split up the words
        List<string> wordList = text.Split(" ").ToList();

        // create a list of Word objects
        wordObjects = new List<Word>();

        // split up the words into strings to create Word objects
        foreach (string word in wordList)
        {
            Word oneWord = new Word(word);
            wordObjects.Add(oneWord);
        }
    }

    /* Reference is a property for the reference attribute to 
    get and set the reference
    Parameter: none
    Return: string, the reference
    */
    public Reference Reference
    {
        get { return reference; }
        set { reference = value; }
    }

    /* Text is a property for the text attribute to
    get and set the text
    Return: string, the text
    */
    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }
}
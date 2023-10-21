using System;

// Word class
public class Word
{
    // private attribute
    private string _word;   // a word from the text

    /* HideWord is a method that hides the word
    by replacing each letter with an underscore
    Parameter: none
    Return: string, the word hidden 
    */
    public string HideWord()
    {
        // if the word is null, return a message
        if (_word == null)
        {
            return "No word to hide.";
        }
        // if the word is not null, hide the word
        else
        {
            // loop through each letter in the word
            foreach (char letter in _word)
            {
                // replace it with an underscore 
                _word = _word.Replace(letter, '_');
            }
            return _word;
        }
    }

    /* ShowWord is a method that returns the word as is
    Parameter: none
    Return: string, the word
    */
    public string ShowWord()
    {
        return $"{_word}";
    }

    /* IsHidden is a method that checks if the word is 
    hidden or not
    Parameter: none
    Return: bool, true if the word is hidden, false if not
    */
    public bool IsHidden()
    {
        // if the word is null, return false
        if (_word == null)
        {
            return false;
        }
        // if the word is not null
        else
        {
            // if it contains an underscore, return true
            if (_word.Contains("_"))
            {
                return true;
            }
            // if it does not contain an underscore, return false
            else
            {
                return false;
            }
        }
    }

    /* GetRenderedText is a method that checks if the word is 
    hidden or not and calls for the appropriate method
    Parameter: none
    Return: string, the word hidden or shown
    */
    public string GetRenderedText()
    {
        // if the word is hidden, return the hidden word
        if (IsHidden() == true)
        {
            return HideWord();
        }
        // if the word is not hidden, return the shown word
        else
        {
            return ShowWord();
        }
    }

    /* Word is a constructor that takes in a word
    Parameter: string word
    Return: none
    */
    public Word(string word)
    {
        // accept the text of the word to save it as an attribute
        _word = word;
        // set the initial visibility of the word
        ShowWord();
    }
}
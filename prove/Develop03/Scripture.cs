using System

private string _reference;
private string _text;

public string HideWords()
{
    string[] words = _text.Split(' ');
    Random random = new Random();
    int randomIndex = random.Next(0, words.Length);
    words[randomIndex] = "______";
    _text = string.Join(" ", words);
    return _text;
}

public string GetRenderedText()
{
    return $"{_reference} {_text}";
}

public string IsCompletelyHidden()
{
    return _text.Contains("______");
}

public Scripture(string reference, string text)
{
    _reference = reference;
    _text = text;
}
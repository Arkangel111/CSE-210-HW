using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //split up words in text and save as word object in the list _words
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

        //split and then loop through each word
        //create word object and put it into _words
    }
    public Reference Reference => _reference;
    public void HideRandomWords()
    {
        // need to randomly select 'numbertohide' of those words
        Random random = new Random();
        int numberToHide = random.Next(1, 4);

        // need to find a set of visible words
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        // set the state of a randomly selected group of words to hidden
        numberToHide = Math.Min(numberToHide, visibleWords.Count);

        // Use the Hide function
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        //Reference and all the words
        string referenceText = _reference.GetDisplayText() + "\n";

        foreach (var word in _words)
        {
            referenceText += word.GetDisplayText() + " ";
        }

        return referenceText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}

// 3 john 5:13 // 

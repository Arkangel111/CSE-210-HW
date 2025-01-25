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

    public void HideRandomWords(int numbertohide)
    {
        // set the state of a randomly selected group of words to hidden
        // need to find a set of visible words
        // need to randomly select 'numbertohide' of those words
        // Use the Hide function
    }

    public string GetDisplayText()
    {
        //Reference and all the words
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}

// 3 john 5:13 // 

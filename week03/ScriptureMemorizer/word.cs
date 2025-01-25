using System;
using System.ComponentModel;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return false;
    }
    public string GetDisplayText()
    {
        // should return the word if visible or return underscores ___ if hidden.
        return _text;
    }
}


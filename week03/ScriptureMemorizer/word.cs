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
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        // should return the word if visible or return underscores ___ if hidden.
        // adjusted text to _ based on length of word.
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}


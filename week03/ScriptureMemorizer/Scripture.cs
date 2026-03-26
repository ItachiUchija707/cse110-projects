using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) 
    {
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {   
            Word newWord = new Word(part);
            _words.Add(newWord);
        }

        _reference = reference;
    }

    public string GetDisplayText()
    {   
        string scriptureText = "";
        scriptureText += _reference.GetDisplayText() + ": ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText();
            scriptureText += " ";
        }

        return scriptureText;
    }

    public void HideRandomWords(int numberToHide)
    {
    
        Random randomNumber = new Random();
        for (int i= 0; i < numberToHide; i++)
        {   
            
            int index = randomNumber.Next(_words.Count);
            if (_words[index].IsHidden() == false) 
            {
                _words[index].Hide();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
        
    }


}
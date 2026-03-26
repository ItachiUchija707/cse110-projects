public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
       _isHidden = false; 
    }

    public void Hide()
    {   
       _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {   
            string hidWord = "";
            foreach (char letter in _word)
            {   
                hidWord += "_";
            }

            return hidWord;
        }

        else
        {
            return _word;
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
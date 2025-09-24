public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }

    public void Hide() // hide the word 
    {
        _isHidden = true;
    }

    public void Show() // show the word 
    {
        _isHidden = false;
    }

    public bool IsHidden() // check if the word is hidden
    {
        return _isHidden;
    }
    
    public string GetDisplayText ()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length);

        }
        else
        {
            return _word;
        }
    }

}
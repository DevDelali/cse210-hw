using System;
using System.Linq;

public class Scripture
{
    private List<Word> _words;

    public Scripture(string text)
    {
        _words = new List<Word>();

        foreach (string _word in text.Split(' '))
        {
            _words.Add(new Word(_word));
        }
    }

    public void HideRandomWord()
    {
        // Get all visible words
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0)
            return; // All words are hidden

        Random rand = new Random();
        int index = rand.Next(visibleWords.Count);
        visibleWords[index].Hide();
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{scriptureText.Trim()}";
    }

}

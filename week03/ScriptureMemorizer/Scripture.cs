using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _rand = new Random();

    public Scripture(Reference Reference, string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

        _reference = Reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !isCompletelyHidden())
        {
            int index = _rand.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}
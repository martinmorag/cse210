public class Scripture {
    
    //private Reference _reference;
    private List<Word> _words = new List<Word>();
    public List<Word> _Words 
    {
        get{ return _words; }
    }

    public Scripture(string text)
    {
        string[] scriptureList = text.Split(" ");
        foreach(string word in scriptureList)
        {
            Word something = new Word(word);
            _words.Add(something);
        }
        //_reference = reference;
    }

    public bool AllWordsHidden()
    {
        foreach(Word word in _words)
        {
            if(word.IsShown())
                return false;
        }
        return true;
    }


}
public class Word {
    private string _word;

    private bool _wordIsShown;

    public Word(string word) 
    {
        _word = word;
        _wordIsShown = true;
    }


    public void Hide() {
        char[] letters = _word.ToCharArray(); 
        for(int i = 0;i < letters.Length; i++) {  
            letters[i] = '_';  
        }
        _word = new String(letters);
        _wordIsShown = false;
    }
    public bool IsShown() {
        return _wordIsShown;
    }
    public string GetRenderedText() {
        return _word;
    }
}

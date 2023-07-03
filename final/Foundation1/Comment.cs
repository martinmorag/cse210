public class Comment 
{
    public string _name;
    public string _text;
    public List<Comment> _theListPartTwo = new List<Comment>();
    public void InsertPartTwo(string name, string text)
    {
        Comment comment = new Comment();
        comment._name = name;
        comment._text = text;
        _theListPartTwo.Add(comment);
    }
    public void DisplayPartTwo()
    {
        Console.WriteLine($"{_name} commented:");
        Console.WriteLine($"{_text}");
    }
    public void DisplayItPartTwo()
    {
        foreach(Comment comment in _theListPartTwo)
        {
            comment.DisplayPartTwo();
        }
    }
}
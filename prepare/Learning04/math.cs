public class Math : General {

    protected string _textBookSection = "";
    protected string _problems = "";

    public Math(string studentName,  string topic, string textBookSection, string problems) : base(studentName, topic) 
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"{_studentName}, {_topic}, Section{_textBookSection}, Problems{_problems}";
    }

}
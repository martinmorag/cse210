public class General {
    
    protected string _studentName = "";
    protected string _topic = "";

    public General(string studentName, string topic) 
    {
        _topic = topic;
        _studentName = studentName;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary() {
        return $"{_studentName}, {_topic}";
    }

}
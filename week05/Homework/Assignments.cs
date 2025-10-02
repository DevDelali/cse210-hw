using System.Dynamic;

public class Assignments
{
    protected string _studentName;
    protected string _topic;


    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
        
    }

    public string GetSummary()
    {
        return $"{_topic} - {_studentName}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}
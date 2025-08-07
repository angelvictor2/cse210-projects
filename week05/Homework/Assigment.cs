
public class Assigment
{
    private string _studentname = "";
    private string _topic = "";

    public Assigment(string studentname, string topic)
    {
        _studentname = studentname;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentname} -  {_topic}";

    }

    public string GetStudentName()
    {
        return _studentname;
    }

    public string GetTopic()
    {
        return _topic;
    }
}
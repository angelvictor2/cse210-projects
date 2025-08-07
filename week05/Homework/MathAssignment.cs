
public class MathAssignment : Assigment
{
    private string _textBokkSection = "";
    private string _problems = "";

    public MathAssignment(string studentname, string topic, string textBookSection, string problems) : base(studentname, topic)
    {
        _textBokkSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"{_textBokkSection} {_problems}";
        
    }
}
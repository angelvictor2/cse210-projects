
using System.Reflection;

public class Video
{
    public string _title = "";
    public string _author = "";
    public float _length = 0;

    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetComments()
    {
        string result = "";

        foreach(Comment comment in _comments )
        {
            result += $"- {comment._name}: {comment._text}\n";
        }

        return result;
    }

    

}
public class Comment
{
    private string _name;
    private string _commentInText;

    public Comment(string name, string commentInText)
    {
        _name = name;
        _commentInText = commentInText;

    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_commentInText}");
    }
}
public class YouTubeVideo
{
    private string _title;
    private string _author;
    private double _lengthOfVideo;  // length in minutes
    private List<Comment> _comments = new List<Comment>();

    // Constructor to set up a new video
    public YouTubeVideo(string title, string author, double lengthOfVideo)
    {
        _title = title;
        _author = author;
        _lengthOfVideo = lengthOfVideo;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthOfVideo} minutes");
        Console.WriteLine($"Comments: {GetNumberOfComments()}\n");
    }

    public void DisplayAllComments()
    {
        Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
    }
}

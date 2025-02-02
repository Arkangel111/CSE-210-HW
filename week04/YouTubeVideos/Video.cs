using System;
public class Video

{
    private int _length;
    private string _author;
    private string _title;
    private List<Comment> _comments;

    public Video(int length, string author, string title)
    {
        _length = length;
        _author = author;
        _title = title;
        _comments = new List<Comment>();
    }

    public void AddComment(string username, string text)
    {
        Comment newComment = new Comment(username, text);
        _comments.Add(newComment);
    }

    public void DisplayComments()
    {
        if (_comments.Count == 0)
        {
            Console.WriteLine("Be the first to comment!");
        }
        else
        {
            foreach (var comment in _comments)
            {
                comment.Display();
            }
        }
    }
    public int CommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comment count: {CommentCount()}");
        Console.WriteLine("\nUser comments:");
        DisplayComments();
        Console.WriteLine("======================");
    }

}

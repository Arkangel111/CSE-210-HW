using System;

public class Comment
{
    private string _username;
    private string _comment;

    public Comment(string username, string comment)
    {
        _username = username;
        _comment = comment;
    }

    public string GetUserName()
    {
        return _username;
    }

    public string GetComment()
    {
        return _comment;
    }
}

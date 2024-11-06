namespace Resulver;

public class ResultError
{
    public ResultError(string message, string? title = null, string? id = null)
    {
        Id = id ?? GetType().Name;
        Title = title;
        Message = message;
    }

    public string Id { get; }
    public string? Title { get; }
    public string Message { get; }
}
namespace Resulver;

public class ResultError
{
    public string Id { get; }
    public string? Title { get; }
    public string Message { get; }

    public ResultError(string message, string? title = null, string? id = null)
    {
        Id = id ?? this.GetType().Name;
        Title = title;
        Message = message;
    }

    public static implicit operator Result(ResultError error) => new(error);
}

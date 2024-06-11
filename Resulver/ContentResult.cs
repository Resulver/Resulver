namespace Resulver;

public class ContentResult<TContent> : Result
{
    public required TContent Content { get; set; }

    public ContentResult(string? message = null) : base(message) { }

    public ContentResult(ResultError error) : base(error) { }
}

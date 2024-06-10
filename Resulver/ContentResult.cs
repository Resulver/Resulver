namespace Resulver;

public abstract class ContentResult<TContent> : Result
{
    public required TContent Content { get; set; }

    public ContentResult(TContent content, string? message = null) :
        base(message)
    {
        Content = content;
    }

    public ContentResult(ResultError error) : base(error) { }
}

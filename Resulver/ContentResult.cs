namespace Resulver;

public abstract class ContentResult<TContent> : Result
{
    public required TContent Content { get; set; }

    public ContentResult(TContent content)
    {
        Content = content;
    }
}

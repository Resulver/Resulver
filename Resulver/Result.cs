namespace Resulver;

public abstract class Result<TContent> : IResult<TContent>
    where TContent : class
{
    public bool IsSuccess { get; }
    public bool IsFailure { get => !IsSuccess; }

    public IResultError? Error { get; }

    public string? Message { get; set; }

    public TContent? Content { get; set; }

    public Result(TContent? content = null, string? message = null)
    {
        Message = message;
        IsSuccess = true;
        Content = content;
    }

    public Result(IResultError error)
    {
        IsSuccess = false;
        Error = error;
    }
}

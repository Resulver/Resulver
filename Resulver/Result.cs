namespace Resulver;

public abstract class Result<TContent> : IResult<TContent>
{
    public bool IsSuccess { get; }
    public bool IsFailure { get => !IsSuccess; }

    public IResultError? Error { get; }

    public string? Message { get; set; }

    public TContent? Content { get; set; }

    public Result(TContent? content, string? message)
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

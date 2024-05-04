namespace Resulver;

public abstract class Result<TContent> : IResult<TContent>
{
    public bool IsSuccess { get; }
    public bool IsFailure { get => !IsSuccess; }

    public IError? Error { get; }

    public TContent? Content { get; set; }

    public string? Message { get; }

    public Result(TContent content, string? message = null)
    {
        IsSuccess = true;
        Content = content;
        Message = message;
    }

    public Result(IError error)
    {
        IsSuccess = false;
        Error = error;
        Message = error.Message;
    }
}

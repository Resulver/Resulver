namespace Resulver;

public abstract class Result<TContent> : IResult<TContent>
{
    public bool IsSuccess { get; }
    public bool IsFailure { get => !IsSuccess; }

    public IError? Error { get; }

    public TContent? Content { get; set; }

    public Result(TContent content)
    {
        IsSuccess = true;
        Content = content;
    }

    public Result(IError error)
    {
        IsSuccess = false;
        Error = error;
    }
}

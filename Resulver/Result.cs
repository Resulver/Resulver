namespace Resulver;

public abstract class Result : IResult
{
    public bool IsSuccess { get; }
    public bool IsFailure { get => !IsSuccess; }

    public IResultError? Error { get; }

    public string? Message { get; set; }

    public Result(string? message = null)
    {
        Message = message;
        IsSuccess = true;
    }

    public Result(IResultError error)
    {
        IsSuccess = false;
        Error = error;
    }
}

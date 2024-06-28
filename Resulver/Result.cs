namespace Resulver;

public class Result
{
    public bool IsSuccess => Errors.Count == 0;
    public bool IsFailure => Errors.Count > 0;

    public List<ResultError> Errors { get; init; } = [];

    public string? Message { get; init; }

    public Result(params ResultError[] errors)
    {
        Errors.AddRange(errors);
    }

    public Result(string? message = null)
    {
        Message = message;
    }
}

public class Result<TContent> : Result
{
    public TContent? Content { get; set; }
    public Result(string? message = null)
    {
        Message = message;
    }

    public Result(params ResultError[] errors)
    {
        Errors.AddRange(errors);
    }

    public Result(TContent content)
    {
        Content = content;
    }
}

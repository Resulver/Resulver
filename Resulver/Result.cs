namespace Resulver;

public sealed class Result : IResult
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

public sealed class Result<TContent> : IResult<TContent>
{
    public bool IsSuccess => Errors.Count == 0;
    public bool IsFailure => Errors.Count > 0;

    public List<ResultError> Errors { get; init; } = [];

    public string? Message { get; init; }

    public TContent? Content { get; set; }
    public Result(params ResultError[] errors)
    {
        Errors.AddRange(errors);
    }

    public Result(string? message = null)
    {
        Message = message;
    }

    public Result(TContent content)
    {
        Content = content;
    }
}

namespace Resulver;

public class Result : IResult
{
    public bool IsSuccess { get => Errors.Count == 0; }
    public bool IsFailure { get => Errors.Count > 0; }

    public List<IResultError> Errors { get; init; } = [];

    public string? Message { get; init; }

    public Result(string? message = null)
    {
        Message = message;
    }

    public Result(IResultError error)
    {
        Errors.Add(error);
    }
}

public class Result<TContent> : Result, IResult<TContent>
{
    public TContent? Content { get; set; }

    public Result(TContent? content, string? message = null) : base(message)
    {
        Content = content;
    }

    public Result(ResultError error) : base(error) { }
}

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
    public required TContent Content { get; set; }

    public Result(string? message = null) : base(message) { }

    public Result(ResultError error) : base(error) { }
}

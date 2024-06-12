namespace Resulver;

public interface IResult
{
    public bool IsFailure { get; }
    public bool IsSuccess { get; }

    public string? Message { get; init; }
    public List<IResultError> Errors { get; init; }
}

public interface IResult<TContent> : IResult
{
    public TContent? Content { get; set; }
}
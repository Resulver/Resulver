namespace Resulver;

internal interface IResult
{
    public bool IsFailure { get; }
    public bool IsSuccess { get; }

    public string? Message { get; init; }
    public List<ResultError> Errors { get; init; }
}

internal interface IResult<TContent> : IResult
{
    public TContent? Content { get; set; }
}
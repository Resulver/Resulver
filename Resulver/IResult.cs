namespace Resulver;

public interface IResult
{
    public bool IsFailure { get; }
    public bool IsSuccess { get; }

    public string? Message { get; set; }
    public IResultError? Error { get; }
}

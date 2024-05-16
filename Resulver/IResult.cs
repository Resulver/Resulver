namespace Resulver;

public interface IResult<TContent>
{
    public bool IsFailure { get; }
    public bool IsSuccess { get; }

    public IError? Error { get; }
    public TContent? Content { get; set; }
}

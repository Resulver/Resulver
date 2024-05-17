namespace Resulver;

public class ResultError(string message) : IResultError
{
    public string Message { get; set; } = message;
}

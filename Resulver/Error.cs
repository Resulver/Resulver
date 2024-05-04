namespace Resulver;

public class Error(string message) : IError
{
    public string Message { get; set; } = message;
}

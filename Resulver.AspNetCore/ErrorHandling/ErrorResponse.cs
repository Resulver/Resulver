namespace Resulver.AspNetCore.ErrorHandling;

public class ErrorResponse
{
    public required string Error { get; set; }
    public string? Message { get; set; }
}

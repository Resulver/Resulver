namespace Resulver.AspNetCore.ErrorHandling;

public class ErrorResponse
{
    public required string ErrorName { get; set; }
    public string? Message { get; set; }
}

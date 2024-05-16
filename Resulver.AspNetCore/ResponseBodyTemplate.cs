using Resulver.AspNetCore.ErrorHandling;

namespace Resulver.AspNetCore;

public class ResponseBodyTemplate<TContent>
{
    public ErrorResponse? Error { get; set; }
    public string? Message { get; set; }
    public TContent? Content { get; set; }
}

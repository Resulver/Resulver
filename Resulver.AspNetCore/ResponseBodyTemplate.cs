namespace Resulver.AspNetCore;

public class ResponseBodyTemplate<TContent>
{
    public string? Title { get; set; }
    public string? Message { get; set; }
    public TContent? Content { get; set; }
}

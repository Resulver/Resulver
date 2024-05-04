namespace Resulver.AspNetCore;

public static class ResponseBodyTemplateBuilder
{
    public static ResponseBodyTemplate<TContent> Build<TContent>(
        string? title = null, string? message = null, TContent? content = default)
    {
        return new ResponseBodyTemplate<TContent>
        {
            Content = content,
            Title = title,
            Message = message,
        };
    }
}

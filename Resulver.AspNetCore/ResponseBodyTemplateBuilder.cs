using Resulver.AspNetCore.ErrorHandling;

namespace Resulver.AspNetCore;

public static class ResponseBodyTemplateBuilder
{
    public static ResponseBodyTemplate<TContent> Build<TContent>(
        IResult<TContent> result)
    {
        return new ResponseBodyTemplate<TContent>
        {
            Content = result.Content,
            Message = result.Message,
            Error = result.IsFailure ?
            new ErrorResponse
            {
                Error = result.Error!.GetType().Name,
                Message = result.Error.Message,
            } : null
        };
    }
}

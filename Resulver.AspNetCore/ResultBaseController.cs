using Microsoft.AspNetCore.Mvc;
using Resulver.AspNetCore.ErrorHandling;

namespace Resulver.AspNetCore;

public class ResultBaseController : ControllerBase
{
    readonly IErrorHandler _errorHandler;

    public ResultBaseController(IErrorHandler errorHandler)
    {
        _errorHandler = errorHandler;
    }

    public IActionResult FromResult<TResultContent>(IResult<TResultContent> result, int SuccessStatusCode)
    {
        if (result.IsFailure) return _errorHandler.Handle(result.Error!);

        return ResponseBodyTemplateBuilder.Build(
            message: result.Message,
            content: result.Content)
            .ToActionResult(SuccessStatusCode);
    }
}

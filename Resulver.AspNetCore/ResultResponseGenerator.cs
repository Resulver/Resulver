using Microsoft.AspNetCore.Mvc;

namespace Resulver.AspNetCore;

public static class ResultResponseGenerator
{
    public static IActionResult ToActionResult<TContent>
        (this ResponseBodyTemplate<TContent> template, int statusCode)
    {
        return new ObjectResult(template)
        {
            StatusCode = statusCode
        };
    }
}

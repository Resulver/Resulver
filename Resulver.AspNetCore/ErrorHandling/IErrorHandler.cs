using Microsoft.AspNetCore.Mvc;

namespace Resulver.AspNetCore.ErrorHandling;

public interface IErrorHandler
{
    public IActionResult Handle(IError error);
}
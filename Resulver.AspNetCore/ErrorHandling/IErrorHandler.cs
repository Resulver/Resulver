using Microsoft.AspNetCore.Mvc;

namespace Resulver.AspNetCore.ErrorHandling;

public interface IErrorHandler
{
    public int GetErrorStatusCode(IResultError error);
}
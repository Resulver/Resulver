namespace Resulver;

public class Result
{
    public Result(params ResultError[] errors)
    {
        Errors.AddRange(errors);
    }

    public Result(string? message = null)
    {
        Message = message;
    }

    public bool IsSuccess => Errors.Count == 0;
    public bool IsFailure => Errors.Count > 0;

    public List<ResultError> Errors { get; init; } = [];

    public string? Message { get; init; }

    public static implicit operator Result(ResultError error)
    {
        return new Result(error);
    }

    public static implicit operator Task<Result>(Result result)
    {
        return Task.FromResult(result);
    }
}

public class Result<TContent> : Result
{
    public Result(string? message = null)
    {
        Message = message;
    }

    public Result(params ResultError[] errors)
    {
        Errors.AddRange(errors);
    }

    public Result(TContent content, string? message = null)
    {
        Content = content;
        Message = message;
    }

    public TContent? Content { get; set; }

    public static implicit operator Result<TContent>(ResultError error)
    {
        return new Result<TContent>(error);
    }

    public static implicit operator Task<Result<TContent>>(Result<TContent> result)
    {
        return Task.FromResult(result);
    }

    public static implicit operator Result<TContent>(TContent content)
    {
        return new Result<TContent>(content);
    }

    public static implicit operator TContent?(Result<TContent> result)
    {
        return result.Content;
    }
}
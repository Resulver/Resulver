﻿namespace Resulver;

public interface IResult<TContent>
{
    public bool IsFailure { get; }
    public bool IsSuccess { get; }

    public string? Message { get; set; }
    public IResultError? Error { get; }
    public TContent? Content { get; set; }
}

namespace HotelChain.BusinessLogic.Models;

public abstract class Response
{
    public required bool Success { get; init; }
    public required int StatusCode { get; init; }
}
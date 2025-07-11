namespace HotelChain.BusinessLogic.Models;

public class DeleteHotelResponse : Response
{
    public int? Id { get; init; }
    public string? ErrorMessage { get; init; }
}
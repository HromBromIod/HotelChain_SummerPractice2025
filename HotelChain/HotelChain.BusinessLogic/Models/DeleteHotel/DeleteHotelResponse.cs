namespace HotelChain.BusinessLogic.Models.DeleteHotel;

public class DeleteHotelResponse : Response
{
    public int? Id { get; init; }
    public string? ErrorMessage { get; init; }
}
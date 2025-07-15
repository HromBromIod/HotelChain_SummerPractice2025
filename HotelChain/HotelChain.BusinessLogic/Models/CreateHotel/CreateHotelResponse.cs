namespace HotelChain.BusinessLogic.Models.CreateHotel;

public class CreateHotelResponse : Response
{
    public int? Id { get; init; }
    public DateTime? CreationTime { get; init; }
    public DateTime? ModificationTime { get; init; }
    public string? Name { get; init; }
    public string? PhoneNumber { get; init; }
    public string? Email { get; init; }
    public string? Address { get; init; }
    public string? ErrorMessage { get; init; }
}
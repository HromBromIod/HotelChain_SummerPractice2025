namespace HotelChain.BusinessLogic.Models;

public record CreateHotelRequest(
    string Name,
    string PhoneNumber,
    string Email,
    string Address);
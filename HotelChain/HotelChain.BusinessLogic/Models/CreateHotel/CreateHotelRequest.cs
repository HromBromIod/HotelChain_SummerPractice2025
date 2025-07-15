namespace HotelChain.BusinessLogic.Models.CreateHotel;

public record CreateHotelRequest(
    string Name,
    string PhoneNumber,
    string Email,
    string Address);
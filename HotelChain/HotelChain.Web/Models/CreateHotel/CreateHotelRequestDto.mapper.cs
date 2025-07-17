using HotelChain.BusinessLogic.Models.CreateHotel;

namespace HotelChain.Web.Models.CreateHotel;

internal static class CreateHotelRequestDtoMapper
{
    public static CreateHotelRequest ToRequest(this CreateHotelRequestDto request)
    {
        return new CreateHotelRequest(
            request.Name,
            request.PhoneNumber,
            request.Email,
            request.Address);
    }
}
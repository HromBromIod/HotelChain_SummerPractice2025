using HotelChain.BusinessLogic.Models;

namespace HotelChain.Web.Models.HotelInfo;

internal static class HotelInfoRequestDtoMapper
{
    public static HotelInfoRequest ToRequest(this HotelInfoRequestDto request)
    {
        return new HotelInfoRequest(request.Id);
    }
}
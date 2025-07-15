using HotelChain.BusinessLogic.Models;
using HotelChain.BusinessLogic.Models.HotelInfo;

namespace HotelChain.Web.Models.HotelInfo;

internal static class HotelInfoRequestDtoMapper
{
    public static HotelInfoRequest ToRequest(this HotelInfoRequestDto request)
    {
        return new HotelInfoRequest(request.Id);
    }
}
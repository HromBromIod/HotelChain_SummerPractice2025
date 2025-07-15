using HotelChain.BusinessLogic.Models;
using HotelChain.BusinessLogic.Models.DeleteHotel;

namespace HotelChain.Web.Models.DeleteHotel;

internal static class DeleteHotelRequestDtoMapper
{
    public static DeleteHotelRequest ToRequest(this DeleteHotelRequestDto request)
    {
        return new DeleteHotelRequest(request.Id);
    }
}
using HotelChain.BusinessLogic.Models;

namespace HotelChain.Web.Models.DeleteHotel;

internal static class DeleteHotelRequestDtoMapper
{
    public static DeleteHotelRequest ToRequest(this DeleteHotelRequestDto request)
    {
        return new DeleteHotelRequest(request.Id);
    }
}
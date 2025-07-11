using System.Net;
using HotelChain.BusinessLogic.Models;

namespace HotelChain.Web.Models.DeleteHotel;

internal static class DeleteHotelResponseDtoMapper
{
    public static DeleteHotelResponseDto ToDto(this DeleteHotelResponse response)
    {
        return new DeleteHotelResponseDto
        {
            StatusCode = (HttpStatusCode) response.StatusCode, 
            Id = response.Id!.Value
        };
    }

    public static ErrorResponseDto ToError(this DeleteHotelResponse response)
    {
        return new ErrorResponseDto
        {
            StatusCode = (HttpStatusCode) response.StatusCode,
            ErrorMessage = response.ErrorMessage!
        };
    }
}
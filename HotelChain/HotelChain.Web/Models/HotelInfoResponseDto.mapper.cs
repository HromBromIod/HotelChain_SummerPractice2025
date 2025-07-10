using System.Net;
using HotelChain.BusinessLogic.Models;

namespace HotelChain.Web.Models;

internal static class HotelInfoResponseDtoMapper
{
    public static HotelInfoResponseDto ToDto(this HotelInfoResponse response)
    {
        return new HotelInfoResponseDto
        {
            StatusCode = (HttpStatusCode) response.StatusCode, 
            Id = response.Id!.Value,
            CreationTime = response.CreationTime!.Value,
            ModificationTime = response.ModificationTime!.Value,
            Name = response.Name!,
            PhoneNumber = response.PhoneNumber!,
            Email = response.Email!,
            Address = response.Address!
        };
    }

    public static ErrorResponseDto ToError(this HotelInfoResponse response)
    {
        return new ErrorResponseDto
        {
            StatusCode = (HttpStatusCode) response.StatusCode,
            ErrorMessage = response.ErrorMessage!
        };
    }
}
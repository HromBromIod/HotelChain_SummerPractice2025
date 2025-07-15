using System.Net;
using HotelChain.BusinessLogic.Models;
using HotelChain.BusinessLogic.Models.CreateHotel;

namespace HotelChain.Web.Models.CreateHotel;

internal static class CreateHotelResponseDtoMapper
{
    public static CreateHotelResponseDto ToDto(this CreateHotelResponse response)
    {
        return new CreateHotelResponseDto
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

    public static ErrorResponseDto ToError(this CreateHotelResponse response)
    {
        return new ErrorResponseDto
        {
            StatusCode = (HttpStatusCode) response.StatusCode,
            ErrorMessage = response.ErrorMessage!
        };
    }
}
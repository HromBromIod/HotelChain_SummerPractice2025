using System.Net;

namespace HotelChain.Web.Models;

internal static class ValidationResultMapper
{
    public static ErrorResponseDto ToError(this ValidationResult result)
    {
        return new ErrorResponseDto
        {
            StatusCode = (HttpStatusCode) result.StatusCode,
            ErrorMessage = result.ErrorMessage!
        };
    }
}
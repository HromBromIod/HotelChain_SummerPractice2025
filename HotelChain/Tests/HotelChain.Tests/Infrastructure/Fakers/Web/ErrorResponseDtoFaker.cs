using System.Net;
using AutoBogus;
using HotelChain.Web.Models;

namespace HotelChain.Tests.Infrastructure.Fakers.Web;

internal static class ErrorResponseDtoFaker
{
    private static HttpStatusCode _validStatusCode = HttpStatusCode.BadRequest;
    private static string _validErrorMessage = "error_message";
    public static ErrorResponseDto GenerateValidHotelInfoResponse()
    {
        var faker = new AutoFaker<ErrorResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.ErrorMessage, s => _validErrorMessage);
    }
}
using System.Text.Json.Serialization;

namespace HotelChain.Web.Models;

public class ErrorResponseDto : ResponseDto
{
    [JsonPropertyName("error_message")]
    public required string ErrorMessage { get; init; }
}
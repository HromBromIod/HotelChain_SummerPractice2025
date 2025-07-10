using System.Net;
using System.Text.Json.Serialization;

namespace HotelChain.Web.Models;

[JsonDerivedType(typeof(HotelInfoResponseDto))]
[JsonDerivedType(typeof(ErrorResponseDto))]
public abstract class ResponseDto
{
    [JsonPropertyName("status_code")]
    public required HttpStatusCode StatusCode { get; init; }
}
using System.Net;
using System.Text.Json.Serialization;
using HotelChain.Web.Models.CreateHotel;
using HotelChain.Web.Models.DeleteHotel;
using HotelChain.Web.Models.HotelInfo;

namespace HotelChain.Web.Models;

[JsonDerivedType(typeof(HotelInfoResponseDto))]
[JsonDerivedType(typeof(CreateHotelResponseDto))]
[JsonDerivedType(typeof(DeleteHotelResponseDto))]
[JsonDerivedType(typeof(ErrorResponseDto))]
public abstract class ResponseDto
{
    [JsonPropertyName("status_code")]
    public required HttpStatusCode StatusCode { get; init; }
}
using System.Text.Json.Serialization;

namespace HotelChain.Web.Models.HotelInfo;

public class HotelInfoRequestDto
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }
}
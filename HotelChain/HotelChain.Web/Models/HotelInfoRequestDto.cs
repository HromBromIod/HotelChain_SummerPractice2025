using System.Text.Json.Serialization;

namespace HotelChain.Web.Models;

public class HotelInfoRequestDto
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }
}
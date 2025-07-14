using System.Text.Json.Serialization;

namespace HotelChain.Web.Models.CreateHotel;

public class CreateHotelRequestDto
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    [JsonPropertyName("phone_number")]
    public required string PhoneNumber { get; init; }
    [JsonPropertyName("email")]
    public required string Email { get; init; }
    [JsonPropertyName("address")]
    public required string Address { get; init; }
}
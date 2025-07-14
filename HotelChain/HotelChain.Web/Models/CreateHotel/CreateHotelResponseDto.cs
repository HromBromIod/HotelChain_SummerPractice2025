using System.Text.Json.Serialization;

namespace HotelChain.Web.Models.CreateHotel;

public class CreateHotelResponseDto : ResponseDto
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }
    [JsonPropertyName("created_at")]
    public required DateTime CreationTime { get; init; }
    [JsonPropertyName("last_modified_at")]
    public required DateTime ModificationTime { get; init; }
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    [JsonPropertyName("phone_number")]
    public required string PhoneNumber { get; init; }
    [JsonPropertyName("email")]
    public required string Email { get; init; }
    [JsonPropertyName("address")]
    public required string Address { get; init; }
}
using System.Text.Json.Serialization;

namespace HotelChain.Web.Models.DeleteHotel;

public class DeleteHotelRequestDto
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }
}
using System.Text.Json.Serialization;

namespace HotelChain.Web.Models.DeleteHotel;

public class DeleteHotelResponseDto : ResponseDto
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }
}
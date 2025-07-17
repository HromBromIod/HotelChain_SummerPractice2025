using AutoBogus;
using HotelChain.Web.Models.DeleteHotel;

namespace HotelChain.Tests.Infrastructure.Fakers.Web.DeleteHotel;

internal static class DeleteHotelRequestDtoFaker
{
    private static int _validId = 12345;

    public static DeleteHotelRequestDto? GenerateNull()
        => default;

    public static DeleteHotelRequestDto GenerateValid()
    {
        var faker = new AutoFaker<DeleteHotelRequestDto>();
        return faker
            .RuleFor(p => p.Id, s => _validId);
    }

    public static DeleteHotelRequestDto GenerateInvalidId()
    {
        var faker = new AutoFaker<DeleteHotelRequestDto>();
        return faker
            .RuleFor(p => p.Id, s => -12345);
    }
}
using AutoBogus;
using HotelChain.Web.Models.HotelInfo;

namespace HotelChain.Tests.Infrastructure.Fakers.Web.HotelInfo;

internal static class HotelInfoRequestDtoFaker
{
    private static int _validId = 12345;

    public static HotelInfoRequestDto? GenerateNull()
        => default;

    public static HotelInfoRequestDto GenerateValid()
    {
        var faker = new AutoFaker<HotelInfoRequestDto>();
        return faker
            .RuleFor(p => p.Id, s => _validId);
    }

    public static HotelInfoRequestDto GenerateInvalidId()
    {
        var faker = new AutoFaker<HotelInfoRequestDto>();
        return faker
            .RuleFor(p => p.Id, s => -12345);
    }
}
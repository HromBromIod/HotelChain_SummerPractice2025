using AutoBogus;
using HotelChain.BusinessLogic.Models.HotelInfo;

namespace HotelChain.Tests.Infrastructure.Fakers.Web.HotelInfo;

internal static class HotelInfoRequestFaker
{
    private static int _validId = 12345;

    public static HotelInfoRequest? GenerateNull()
        => default;

    public static HotelInfoRequest GenerateValid()
    {
        var faker = new AutoFaker<HotelInfoRequest>();
        return faker
            .RuleFor(p => p.Id, s => _validId);
    }

    public static HotelInfoRequest GenerateInvalidId()
    {
        var faker = new AutoFaker<HotelInfoRequest>();
        return faker
            .RuleFor(p => p.Id, s => -12345);
    }
}
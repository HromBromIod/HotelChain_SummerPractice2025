using AutoBogus;
using HotelChain.BusinessLogic.Models.DeleteHotel;

namespace HotelChain.Tests.Infrastructure.Fakers.BusinessLogic;

internal static class DeleteHotelRequestFaker
{
    private static int _validId = 12345;

    public static DeleteHotelRequest? GenerateNull()
        => default;

    public static DeleteHotelRequest GenerateValid()
    {
        var faker = new AutoFaker<DeleteHotelRequest>();
        return faker
            .RuleFor(p => p.Id, s => _validId);
    }

    public static DeleteHotelRequest GenerateInvalidId()
    {
        var faker = new AutoFaker<DeleteHotelRequest>();
        return faker
            .RuleFor(p => p.Id, s => -12345);
    }
}
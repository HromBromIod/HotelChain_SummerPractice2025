using AutoBogus;
using HotelChain.Web.Models.CreateHotel;

namespace HotelChain.Tests.Infrastructure.Fakers;

internal static class CreateHotelRequestDtoFaker
{
    private static string _validName = "hotel_name";
    private static string _validPhoneNumber = "12345678";
    private static string _validEmail = "email@email.com";
    private static string _validAddress = "hotel_address";
    
    public static CreateHotelRequestDto? GenerateNull()
        => default;

    public static CreateHotelRequestDto GenerateValid()
    {
        var faker = new AutoFaker<CreateHotelRequestDto>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequestDto GenerateNoName()
    {
        var faker = new AutoFaker<CreateHotelRequestDto>();
        return faker
            .RuleFor(p => p.Name, s => default)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequestDto GenerateNoPhoneNumber()
    {
        var faker = new AutoFaker<CreateHotelRequestDto>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => default)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequestDto GenerateNoEmail()
    {
        var faker = new AutoFaker<CreateHotelRequestDto>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => default)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequestDto GenerateNoAddress()
    {
        var faker = new AutoFaker<CreateHotelRequestDto>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => default);
    }
    
    public static CreateHotelRequestDto GenerateInvalidPhoneNumber()
    {
        var faker = new AutoFaker<CreateHotelRequestDto>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => "abcdefg")
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
}
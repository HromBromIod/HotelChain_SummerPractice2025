using AutoBogus;
using HotelChain.BusinessLogic.Models.CreateHotel;

namespace HotelChain.Tests.Infrastructure.Fakers.BusinessLogic;

internal static class CreateHotelRequestFaker
{
    private static string _validName = "hotel_name";
    private static string _validPhoneNumber = "12345678";
    private static string _validEmail = "email@email.com";
    private static string _validAddress = "hotel_address";
    
    public static CreateHotelRequest? GenerateNull()
        => default;

    public static CreateHotelRequest GenerateValid()
    {
        var faker = new AutoFaker<CreateHotelRequest>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequest GenerateNoName()
    {
        var faker = new AutoFaker<CreateHotelRequest>();
        return faker
            .RuleFor(p => p.Name, s => default)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequest GenerateNoPhoneNumber()
    {
        var faker = new AutoFaker<CreateHotelRequest>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => default)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequest GenerateNoEmail()
    {
        var faker = new AutoFaker<CreateHotelRequest>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => default)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static CreateHotelRequest GenerateNoAddress()
    {
        var faker = new AutoFaker<CreateHotelRequest>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => default);
    }
    
    public static CreateHotelRequest GenerateInvalidPhoneNumber()
    {
        var faker = new AutoFaker<CreateHotelRequest>();
        return faker
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => "abcdefg")
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
}
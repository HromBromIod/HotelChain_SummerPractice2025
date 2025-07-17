using System;
using System.Net;
using AutoBogus;
using HotelChain.Web.Models.HotelInfo;

namespace HotelChain.Tests.Infrastructure.Fakers.Web.HotelInfo;

internal static class HotelInfoResponseDtoFaker
{
    private static HttpStatusCode _validStatusCode = HttpStatusCode.OK;
    private static int _validId = 12345;
    private static DateTime _validCreationTime = DateTime.UtcNow.AddDays(-2).Date;
    private static DateTime _validModificationTime = DateTime.UtcNow.AddDays(-1).Date;
    private static string _validName = "hotel_name";
    private static string _validPhoneNumber = "12345678";
    private static string _validEmail = "email@email.com";
    private static string _validAddress = "hotel_address";

    public static HotelInfoResponseDto GenerateValid()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static HotelInfoResponseDto GenerateNoName()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => default)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static HotelInfoResponseDto GenerateNoPhoneNumber()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => default)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static HotelInfoResponseDto GenerateNoEmail()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => default)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static HotelInfoResponseDto GenerateNoAddress()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => default);
    }
    
    public static HotelInfoResponseDto GenerateInvalidId()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => -12345)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static HotelInfoResponseDto GenerateInvalidCreationModificationTime()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validModificationTime)
            .RuleFor(p => p.ModificationTime, s => _validCreationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
    
    public static HotelInfoResponseDto GenerateInvalidPhoneNumber()
    {
        var faker = new AutoFaker<HotelInfoResponseDto>();
        return faker
            .RuleFor(p => p.StatusCode, s => _validStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => "abcdefg")
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress);
    }
}
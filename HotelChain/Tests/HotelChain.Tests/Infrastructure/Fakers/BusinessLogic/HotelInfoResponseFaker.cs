using System;
using AutoBogus;
using HotelChain.BusinessLogic.Models.HotelInfo;

namespace HotelChain.Tests.Infrastructure.Fakers.BusinessLogic;

internal static class HotelInfoResponseFaker
{
    private static bool _validSuccess = true;
    private static bool _validNotSuccess = false;
    private static int _validSuccessStatusCode = 200;
    private static int _validUnsuccessStatusCode = 400;
    private static int _validId = 12345;
    private static DateTime _validCreationTime = DateTime.UtcNow.AddDays(-2).Date;
    private static DateTime _validModificationTime = DateTime.UtcNow.AddDays(-1).Date;
    private static string _validName = "hotel_name";
    private static string _validPhoneNumber = "12345678";
    private static string _validEmail = "email@email.com";
    private static string _validAddress = "hotel_address";
    private static string _validErrorMessage = "error_message";
    
    public static HotelInfoResponse? GenerateNull()
        => default;

    public static HotelInfoResponse GenerateValidSuccess()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }

    public static HotelInfoResponse GenerateValidNotSuccess()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validNotSuccess)
            .RuleFor(p => p.StatusCode, s => _validUnsuccessStatusCode)
            .RuleFor(p => p.Id, s => default)
            .RuleFor(p => p.CreationTime, s => default)
            .RuleFor(p => p.ModificationTime, s => default)
            .RuleFor(p => p.Name, s => default)
            .RuleFor(p => p.PhoneNumber, s => default)
            .RuleFor(p => p.Email, s => default)
            .RuleFor(p => p.Address, s => default)
            .RuleFor(p => p.ErrorMessage, s => _validErrorMessage);
    }
    
    public static HotelInfoResponse GenerateNoId()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => default)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateNoCreationTime()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => default)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateNoModificationTime()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => default)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }

    public static HotelInfoResponse GenerateNoName()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => default)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateNoPhoneNumber()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => default)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateNoEmail()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => default)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateNoAddress()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => default)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateInvalidId()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => -12345)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateInvalidCreationModificationTime()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validModificationTime)
            .RuleFor(p => p.ModificationTime, s => _validCreationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => _validPhoneNumber)
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
    
    public static HotelInfoResponse GenerateInvalidPhoneNumber()
    {
        var faker = new AutoFaker<HotelInfoResponse>();
        return faker
            .RuleFor(p => p.Success, s => _validSuccess)
            .RuleFor(p => p.StatusCode, s => _validSuccessStatusCode)
            .RuleFor(p => p.Id, s => _validId)
            .RuleFor(p => p.CreationTime, s => _validCreationTime)
            .RuleFor(p => p.ModificationTime, s => _validModificationTime)
            .RuleFor(p => p.Name, s => _validName)
            .RuleFor(p => p.PhoneNumber, s => "abcdefg")
            .RuleFor(p => p.Email, s => _validEmail)
            .RuleFor(p => p.Address, s => _validAddress)
            .RuleFor(p => p.ErrorMessage, s => default);
    }
}
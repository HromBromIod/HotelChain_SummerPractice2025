using System;
using AutoBogus;
using HotelChain.Persistence.Models;

namespace HotelChain.Tests.Infrastructure.Fakers.Persistence.Models;

internal static class HotelDtoFaker
{
    private static int _defaultId = 12345;
    private static DateTime _defaultCreationTime = DateTime.UtcNow.AddDays(-2).Date;
    private static DateTime _defaultModificationTime = DateTime.UtcNow.AddDays(-1).Date;
    private static string _defaultName = "hotel_name";
    private static string _defaultPhoneNumber = "12345678";
    private static string _defaultEmail = "email@email.com";
    private static string _defaultAddress = "hotel_address";

    public static HotelDto Generate(int? id = null, DateTime? creationTime = null, DateTime? modificationTime = null,
        string? name = null, string? phoneNumber = null, string? email = null, string? address = null)
    {
        var faker = new AutoFaker<HotelDto>();
        return faker
            .RuleFor(p => p.Id, s => id ?? _defaultId)
            .RuleFor(p => p.CreationTime, s => creationTime ?? _defaultCreationTime)
            .RuleFor(p => p.ModificationTime, s => modificationTime ?? _defaultModificationTime)
            .RuleFor(p => p.Name, s => name ?? _defaultName)
            .RuleFor(p => p.PhoneNumber, s => phoneNumber ?? _defaultPhoneNumber)
            .RuleFor(p => p.Email, s => email ?? _defaultEmail)
            .RuleFor(p => p.Address, s => address ?? _defaultAddress);
    }
}
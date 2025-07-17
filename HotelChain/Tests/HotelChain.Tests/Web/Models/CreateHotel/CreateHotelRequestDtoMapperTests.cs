using System;
using HotelChain.Tests.Infrastructure.Fakers.BusinessLogic;
using HotelChain.Tests.Infrastructure.Fakers.Web.CreateHotel;
using HotelChain.Web.Models.CreateHotel;

namespace HotelChain.Tests.Web.Models.CreateHotel;

public class CreateHotelRequestDtoMapperTests
{
    [Fact]
    public void ToRequest_Valid_Equivalent()
    {
        var source = CreateHotelRequestDtoFaker.GenerateValid();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, CreateHotelRequestFaker.GenerateValid());
    }
    
    [Fact]
    public void ToRequest_Null_ArgumentError()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNull();

        Assert.Throws<NullReferenceException>(() => source.ToRequest());
    }
    
    [Fact]
    public void ToRequest_NoName_Equivalent()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoName();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, CreateHotelRequestFaker.GenerateNoName());
    }
    
    [Fact]
    public void ToRequest_NoPhoneNumber_Equivalent()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoPhoneNumber();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, CreateHotelRequestFaker.GenerateNoPhoneNumber());
    }
    
    [Fact]
    public void ToRequest_InvalidPhoneNumber_Equivalent()
    {
        var source = CreateHotelRequestDtoFaker.GenerateInvalidPhoneNumber();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, CreateHotelRequestFaker.GenerateInvalidPhoneNumber());
    }
    
    [Fact]
    public void ToRequest_NoEmail_Equivalent()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoEmail();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, CreateHotelRequestFaker.GenerateNoEmail());
    }
    
    [Fact]
    public void ToRequest_NoAddress_Equivalent()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoAddress();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, CreateHotelRequestFaker.GenerateNoAddress());
    }
}
using System;
using HotelChain.Tests.Infrastructure.Fakers.BusinessLogic;
using HotelChain.Tests.Infrastructure.Fakers.Web;
using HotelChain.Tests.Infrastructure.Fakers.Web.HotelInfo;
using HotelChain.Web.Models.HotelInfo;

namespace HotelChain.Tests.Web.Models.HotelInfo;

public sealed class HotelInfoResponseDtoMapperTests
{
    [Fact]
    public void ToRequest_ValidSuccess_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateValidSuccess();
        var result = source.ToDto();

        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateValid());
    }
    
    [Fact]
    public void ToRequest_Null_Throws()
    {
        var source = HotelInfoResponseFaker.GenerateNull();

        Assert.Throws<NullReferenceException>(() => source.ToDto());
    }
    
    [Fact]
    public void ToRequest_NoCreationTime_Throws()
    {
        var source = HotelInfoResponseFaker.GenerateNoCreationTime();

        Assert.Throws<InvalidOperationException>(() => source.ToDto());
    }
    
    [Fact]
    public void ToRequest_NoModificationTime_Throws()
    {
        var source = HotelInfoResponseFaker.GenerateNoModificationTime();

        Assert.Throws<InvalidOperationException>(() => source.ToDto());
    }
    
    [Fact]
    public void ToRequest_InvalidInvalidCreationModificationTime_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateInvalidCreationModificationTime();
        var result = source.ToDto();
        
        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateInvalidCreationModificationTime());
    }

    [Fact]
    public void ToRequest_NoId_Throws()
    {
        var source = HotelInfoResponseFaker.GenerateNoId();

        Assert.Throws<InvalidOperationException>(() => source.ToDto());
    }
    
    [Fact]
    public void ToRequest_InvalidId_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateInvalidId();
        var result = source.ToDto();
        
        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateInvalidId());
    }
    
    [Fact]
    public void ToRequest_NoName_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateNoName();
        var result = source.ToDto();
        
        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateNoName());
    }
    
    [Fact]
    public void ToRequest_NoPhoneNumber_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateNoPhoneNumber();
        var result = source.ToDto();
        
        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateNoPhoneNumber());
    }
    
    [Fact]
    public void ToRequest_InvalidPhoneNumber_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateInvalidPhoneNumber();
        var result = source.ToDto();
        
        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateInvalidPhoneNumber());
    }
    
    [Fact]
    public void ToRequest_NoEmail_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateNoEmail();
        var result = source.ToDto();
        
        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateNoEmail());
    }
    
    [Fact]
    public void ToRequest_NoAddress_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateNoAddress();
        var result = source.ToDto();
        
        Assert.Equivalent(result, HotelInfoResponseDtoFaker.GenerateNoAddress());
    }

    [Fact]
    public void ToError_ValidNotSuccess_Equivalent()
    {
        var source = HotelInfoResponseFaker.GenerateValidNotSuccess();
        var result = source.ToError();

        Assert.Equivalent(result, ErrorResponseDtoFaker.GenerateValidHotelInfoResponse());
    }
}
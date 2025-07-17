using System;
using HotelChain.Tests.Infrastructure.Fakers.Web.HotelInfo;
using HotelChain.Web.Models.HotelInfo;

namespace HotelChain.Tests.Web.Models.HotelInfo;

public class HotelInfoRequestDtoMapperTests
{
    [Fact]
    public void ToRequest_Valid_Equivalent()
    {
        var source = HotelInfoRequestDtoFaker.GenerateValid();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, HotelInfoRequestFaker.GenerateValid());
    }
    
    [Fact]
    public void ToRequest_Null_ArgumentError()
    {
        var source = HotelInfoRequestDtoFaker.GenerateNull();

        Assert.Throws<NullReferenceException>(() => source.ToRequest());
    }
    
    [Fact]
    public void ToRequest_InvalidId_Equivalent()
    {
        var source = HotelInfoRequestDtoFaker.GenerateInvalidId();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, HotelInfoRequestFaker.GenerateInvalidId());
    }
}
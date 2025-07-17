using System;
using HotelChain.Tests.Infrastructure.Fakers.BusinessLogic;
using HotelChain.Tests.Infrastructure.Fakers.Web.DeleteHotel;
using HotelChain.Web.Models.DeleteHotel;

namespace HotelChain.Tests.Web.Models.DeleteHotel;

public class DeleteHotelRequestDtoMapperTests
{
    [Fact]
    public void ToRequest_Valid_Equivalent()
    {
        var source = DeleteHotelRequestDtoFaker.GenerateValid();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, DeleteHotelRequestFaker.GenerateValid());
    }
    
    [Fact]
    public void ToRequest_Null_ArgumentError()
    {
        var source = DeleteHotelRequestDtoFaker.GenerateNull();

        Assert.Throws<NullReferenceException>(() => source.ToRequest());
    }
    
    [Fact]
    public void ToRequest_InvalidId_Equivalent()
    {
        var source = DeleteHotelRequestDtoFaker.GenerateInvalidId();
        var result = source.ToRequest();
        
        Assert.Equivalent(result, DeleteHotelRequestFaker.GenerateInvalidId());
    }
}
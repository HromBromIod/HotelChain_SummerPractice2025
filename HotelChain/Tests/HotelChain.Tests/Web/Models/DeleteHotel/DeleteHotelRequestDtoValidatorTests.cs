using HotelChain.Tests.Infrastructure.Fakers.Web.DeleteHotel;
using HotelChain.Web.Models.DeleteHotel;
using Microsoft.AspNetCore.Http;

namespace HotelChain.Tests.Web.Models.DeleteHotel;

public class DeleteHotelRequestDtoValidatorTests
{
    [Fact]
    public void Validate_Null_InvalidBadRequest()
    {
        var source = DeleteHotelRequestDtoFaker.GenerateNull();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Contains("Request is null", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_InvalidPhoneNumber_InvalidBadRequest()
    {
        var source = DeleteHotelRequestDtoFaker.GenerateInvalidId();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Id must be greater then 0", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_ValidRequest_ValidOk()
    {
        var source = DeleteHotelRequestDtoFaker.GenerateValid();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.True(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status200OK);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Ok", result.ErrorMessage);
    }
}
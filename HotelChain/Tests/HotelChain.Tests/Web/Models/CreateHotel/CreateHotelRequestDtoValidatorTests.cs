using HotelChain.Tests.Infrastructure.Fakers.Web.CreateHotel;
using HotelChain.Web.Models.CreateHotel;
using Microsoft.AspNetCore.Http;

namespace HotelChain.Tests.Web.Models.CreateHotel;

public class CreateHotelRequestDtoValidatorTests
{
    [Fact]
    public void Validate_Null_InvalidBadRequest()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNull();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Contains("Request is null", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_NoName_InvalidBadRequest()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoName();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Name is null or empty", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_NoPhoneNumber_InvalidBadRequest()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoPhoneNumber();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Phone number is null or empty", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_InvalidPhoneNumber_InvalidBadRequest()
    {
        var source = CreateHotelRequestDtoFaker.GenerateInvalidPhoneNumber();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Phone number is invalid", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_NoEmail_InvalidBadRequest()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoEmail();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Email is null or empty", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_NoAddress_InvalidBadRequest()
    {
        var source = CreateHotelRequestDtoFaker.GenerateNoAddress();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.False(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status400BadRequest);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Address is null or empty", result.ErrorMessage);
    }
    
    [Fact]
    public void Validate_ValidRequest_ValidOk()
    {
        var source = CreateHotelRequestDtoFaker.GenerateValid();
        var result = source.Validate();

        Assert.NotNull(result);
        Assert.True(result.IsValid);
        Assert.True(result.StatusCode == StatusCodes.Status200OK);
        Assert.NotNull(result.ErrorMessage);
        Assert.Equal("Ok", result.ErrorMessage);
    }
}
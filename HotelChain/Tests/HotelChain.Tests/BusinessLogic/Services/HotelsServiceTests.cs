using System.Threading;
using System.Threading.Tasks;
using HotelChain.BusinessLogic.Models;
using HotelChain.Tests.Infrastructure.Builders.BusinessLogic;
using HotelChain.Tests.Infrastructure.Fakers.BusinessLogic;
using HotelChain.Tests.Infrastructure.Fakers.Web.HotelInfo;
using Microsoft.AspNetCore.Http;
using Moq;

namespace HotelChain.Tests.BusinessLogic.Services;

public class HotelsServiceTests
{
    [Fact]
    public async Task GetHotelInfoById_ValidRequest_ReturnsSuccessResponse()
    {
        var ct = CancellationToken.None;
        var request = HotelInfoRequestFaker.GenerateValid();
        var builder = HotelsServiceBuilder.CreateDefault();
        var hotelsService = builder.Build();

        var response = await hotelsService.GetHotelInfoById(request, ct);

        Assert.NotNull(response);
        Assert.True(response.Success);
        Assert.Equivalent(StatusCodes.Status200OK, response.StatusCode);
        Assert.Null(response.ErrorMessage);
        builder.HotelsStoreMock.Verify(s => s.GetHotelById(request.Id, ct), Times.Once);
    }
    
    [Fact]
    public async Task GetHotelInfoById_BadRequestId_ReturnsNotSuccessResponse()
    {
        var ct = CancellationToken.None;
        var request = HotelInfoRequestFaker.GenerateValid();
        var builder = HotelsServiceBuilder.CreateDefault();
        builder.HotelsStoreGetHotelByIdReturnsNull();
        var hotelsService = builder.Build();

        var response = await hotelsService.GetHotelInfoById(request, ct);

        Assert.NotNull(response);
        Assert.False(response.Success);
        Assert.Equivalent(StatusCodes.Status404NotFound, response.StatusCode);
        Assert.NotNull(response.ErrorMessage);
        Assert.Equivalent(ErrorResponseConstants.HotelNotFountErrorResponseMessage, response.ErrorMessage);
        builder.HotelsStoreMock.Verify(s => s.GetHotelById(request.Id, ct), Times.Once);
    }
    
    [Fact]
    public async Task CreateHotel_ValidRequest_ReturnsSuccessResponse()
    {
        var ct = CancellationToken.None;
        var request = CreateHotelRequestFaker.GenerateValid();
        var builder = HotelsServiceBuilder.CreateDefault();
        var hotelsService = builder.Build();

        var response = await hotelsService.CreateHotel(request, ct);

        Assert.NotNull(response);
        Assert.True(response.Success);
        Assert.Equivalent(StatusCodes.Status201Created, response.StatusCode);
        Assert.Null(response.ErrorMessage);
        builder.HotelsStoreMock.Verify(s => s.CreateHotelInfo(request.Name, request.PhoneNumber, request.Email, request.Address, ct), Times.Once);
    }
    
    [Fact]
    public async Task CreateHotel_BadRequest_ReturnsNotSuccessResponse()
    {
        var ct = CancellationToken.None;
        var request = CreateHotelRequestFaker.GenerateValid();
        var builder = HotelsServiceBuilder.CreateDefault();
        builder.HotelsStoreCreateHotelInfoReturnsNull();
        var hotelsService = builder.Build();

        var response = await hotelsService.CreateHotel(request, ct);

        Assert.NotNull(response);
        Assert.False(response.Success);
        Assert.Equivalent(StatusCodes.Status400BadRequest, response.StatusCode);
        Assert.NotNull(response.ErrorMessage);
        Assert.Equivalent(ErrorResponseConstants.CreateHotelDoesNotUniqueInfoResponseMessage, response.ErrorMessage);
        builder.HotelsStoreMock.Verify(s => s.CreateHotelInfo(request.Name, request.PhoneNumber, request.Email, request.Address, ct), Times.Once);
    }
    
    [Fact]
    public async Task DeleteHotelById_ValidRequest_ReturnsSuccessResponse()
    {
        var ct = CancellationToken.None;
        var request = DeleteHotelRequestFaker.GenerateValid();
        var builder = HotelsServiceBuilder.CreateDefault();
        var hotelsService = builder.Build();

        var response = await hotelsService.DeleteHotelById(request, ct);

        Assert.NotNull(response);
        Assert.True(response.Success);
        Assert.Equivalent(StatusCodes.Status200OK, response.StatusCode);
        Assert.Null(response.ErrorMessage);
        builder.HotelsStoreMock.Verify(s => s.DeleteHotelById(request.Id, ct), Times.Once);
    }
    
    [Fact]
    public async Task DeleteHotelById_BadRequest_ReturnsNotSuccessResponse()
    {
        var ct = CancellationToken.None;
        var request = DeleteHotelRequestFaker.GenerateValid();
        var builder = HotelsServiceBuilder.CreateDefault();
        builder.HotelsStoreDeleteHotelByIdReturnsFalse();
        var hotelsService = builder.Build();

        var response = await hotelsService.DeleteHotelById(request, ct);

        Assert.NotNull(response);
        Assert.False(response.Success);
        Assert.Equivalent(StatusCodes.Status404NotFound, response.StatusCode);
        Assert.NotNull(response.ErrorMessage);
        Assert.Equivalent(ErrorResponseConstants.HotelNotFountErrorResponseMessage, response.ErrorMessage);
        builder.HotelsStoreMock.Verify(s => s.DeleteHotelById(request.Id, ct), Times.Once);
    }
}
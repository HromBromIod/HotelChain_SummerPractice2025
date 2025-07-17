using System.Threading;
using HotelChain.BusinessLogic.Services.Implementations;
using HotelChain.Persistence.Models;
using HotelChain.Persistence.Stores;
using HotelChain.Tests.Infrastructure.Fakers.Persistence.Models;
using Moq;
using Serilog;

namespace HotelChain.Tests.Infrastructure.Builders.BusinessLogic;

internal class HotelsServiceBuilder
{
    public Mock<ILogger> LoggerMock { get; init; } = new();
    public Mock<IHotelsStore> HotelsStoreMock { get; init; } = new();

    public static HotelsServiceBuilder CreateDefault()
    {
        var builder = new HotelsServiceBuilder();
        builder.InitDefaults();
        return builder;
    }

    private void InitDefaults()
    {
        HotelsStoreMock
            .Setup(x => x.GetHotelById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(HotelDtoFaker.Generate());

        HotelsStoreMock
            .Setup(x => x.CreateHotelInfo(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(HotelDtoFaker.Generate());
        
        HotelsStoreMock
            .Setup(x => x.DeleteHotelById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);
    }

    public HotelsService Build()
        => new HotelsService(LoggerMock.Object, HotelsStoreMock.Object);

    public void HotelsStoreGetHotelByIdReturnsNull()
    {
        HotelsStoreMock
            .Setup(x => x.GetHotelById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(default(HotelDto?));
    }
    
    public void HotelsStoreCreateHotelInfoReturnsNull()
    {
        HotelsStoreMock
            .Setup(x => x.CreateHotelInfo(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(default(HotelDto?));
    }
    
    public void HotelsStoreDeleteHotelByIdReturnsFalse()
    {
        HotelsStoreMock
            .Setup(x => x.DeleteHotelById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);
    }
}
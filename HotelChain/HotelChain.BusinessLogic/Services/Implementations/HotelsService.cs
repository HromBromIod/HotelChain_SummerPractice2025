using System.Net;
using HotelChain.BusinessLogic.Models;
using HotelChain.BusinessLogic.Models.CreateHotel;
using HotelChain.BusinessLogic.Models.DeleteHotel;
using HotelChain.BusinessLogic.Models.HotelInfo;
using HotelChain.Persistence.Stores;
using Serilog;

namespace HotelChain.BusinessLogic.Services.Implementations;

internal class HotelsService(
    ILogger logger,
    IHotelsStore hotelsStore)
    : IHotelsService
{
    public async Task<HotelInfoResponse> GetHotelInfoById(HotelInfoRequest request, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsService)}.{nameof(GetHotelInfoById)}: {request.Id}");
        
        var hotelInfo = await hotelsStore.GetHotelById(request.Id, cancellationToken);

        if (hotelInfo == null)
        {
            logger.Information($"{nameof(HotelsService)}.{nameof(GetHotelInfoById)}: {request.Id} not found");
            
            return new HotelInfoResponse
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.NotFound,
                ErrorMessage = ErrorResponseConstants.HotelNotFountErrorResponseMessage
            };
        }

        logger.Information($"{nameof(HotelsService)}.{nameof(GetHotelInfoById)}: {request.Id} success");
        
        return new HotelInfoResponse
        {
            Success = true,
            StatusCode = 200,
            Id = hotelInfo.Id!.Value,
            CreationTime = hotelInfo.CreationTime!.Value,
            ModificationTime = hotelInfo.ModificationTime!.Value,
            Name = hotelInfo.Name,
            PhoneNumber = hotelInfo.PhoneNumber,
            Email = hotelInfo.Email,
            Address = hotelInfo.Address
        };
    }
    
    public async Task<CreateHotelResponse> CreateHotel(CreateHotelRequest request, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsService)}.{nameof(CreateHotel)}: {request.Name}");
        
        var hotelInfo = await hotelsStore.CreateHotelInfo(
            request.Name,
            request.PhoneNumber,
            request.Email,
            request.Address, 
            cancellationToken);

        if (hotelInfo == null)
        {
            logger.Information($"{nameof(HotelsService)}.{nameof(CreateHotel)}: {request.Name} error");
            
            return new CreateHotelResponse
            {
                Success = false,
                StatusCode = (int) HttpStatusCode.BadRequest,
                ErrorMessage = ErrorResponseConstants.CreateHotelDoesNotUniqueInfoResponseMessage
            };
        }

        logger.Information($"{nameof(HotelsService)}.{nameof(CreateHotel)}: {request.Name} success");
        
        return new CreateHotelResponse
        {
            Success = true,
            StatusCode = 201,
            Id = hotelInfo.Id!.Value,
            CreationTime = hotelInfo.CreationTime!.Value,
            ModificationTime = hotelInfo.ModificationTime!.Value,
            Name = hotelInfo.Name,
            PhoneNumber = hotelInfo.PhoneNumber,
            Email = hotelInfo.Email,
            Address = hotelInfo.Address
        };
    }

    public async Task<DeleteHotelResponse> DeleteHotelById(DeleteHotelRequest request, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsService)}.{nameof(DeleteHotelById)}: {request.Id}");
        
        var result = await hotelsStore.DeleteHotelById(request.Id, cancellationToken);

        if (!result)
        {
            logger.Information($"{nameof(HotelsService)}.{nameof(DeleteHotelById)}: {request.Id} not found");
            
            return new DeleteHotelResponse
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.NotFound,
                ErrorMessage = ErrorResponseConstants.HotelNotFountErrorResponseMessage
            };
        }
        
        logger.Information($"{nameof(HotelsService)}.{nameof(DeleteHotelById)}: {request.Id} success");
        
        return new DeleteHotelResponse
        {
            Success = true,
            StatusCode = 200,
            Id = request.Id
        };
    }
}
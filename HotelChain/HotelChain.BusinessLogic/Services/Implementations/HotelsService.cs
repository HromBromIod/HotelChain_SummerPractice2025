using System.Net;
using HotelChain.BusinessLogic.Models;
using HotelChain.Persistence.Stores;

namespace HotelChain.BusinessLogic.Services.Implementations;

internal class HotelsService(IHotelsStore hotelsStore) : IHotelsService
{
    public async Task<HotelInfoResponse> GetHotelInfoById(HotelInfoRequest request, CancellationToken cancellationToken)
    {
        var hotelInfo = await hotelsStore.GetHotelById(request.Id, cancellationToken);

        if (hotelInfo == null)
        {
            return new HotelInfoResponse
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.NotFound,
                ErrorMessage = ErrorResponseConstants.HotelNotFountErrorResponseMessage
            };
        }

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
        var hotelInfo = await hotelsStore.CreateHotelInfo(
            request.Name,
            request.PhoneNumber,
            request.Email,
            request.Address, 
            cancellationToken);

        if (hotelInfo == null)
        {
            return new CreateHotelResponse
            {
                Success = false,
                StatusCode = (int) HttpStatusCode.BadRequest,
                ErrorMessage = ErrorResponseConstants.CreateHotelDoesNotUniqueInfoResponseMessage
            };
        }

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
        var result = await hotelsStore.DeleteHotelById(request.Id, cancellationToken);

        if (!result)
        {
            return new DeleteHotelResponse
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.NotFound,
                ErrorMessage = ErrorResponseConstants.HotelNotFountErrorResponseMessage
            };
        }
        
        return new DeleteHotelResponse
        {
            Success = true,
            StatusCode = 200,
            Id = request.Id
        };
    }
}
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
                ErrorMessage = ErrorResponseConstants.HotelInfoNotFountErrorResponseMessage
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
}
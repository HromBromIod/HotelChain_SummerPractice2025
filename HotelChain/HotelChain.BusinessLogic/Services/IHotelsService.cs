using HotelChain.BusinessLogic.Models;

namespace HotelChain.BusinessLogic.Services;

public interface IHotelsService
{
    public Task<HotelInfoResponse> GetHotelInfoById(HotelInfoRequest request, CancellationToken cancellationToken);
}
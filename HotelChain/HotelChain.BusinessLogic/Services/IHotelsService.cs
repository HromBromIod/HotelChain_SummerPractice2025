using HotelChain.BusinessLogic.Models;

namespace HotelChain.BusinessLogic.Services;

public interface IHotelsService
{
    public Task<HotelInfoResponse> GetHotelInfoById(HotelInfoRequest request, CancellationToken cancellationToken);
    public Task<CreateHotelResponse> CreateHotel(CreateHotelRequest request, CancellationToken cancellationToken);
    public Task<DeleteHotelResponse> DeleteHotelById(DeleteHotelRequest request, CancellationToken cancellationToken);
}
namespace HotelChain.BusinessLogic.Models;

internal struct ErrorResponseConstants
{
    public const string HotelNotFountErrorResponseMessage = "Hotel with the requested id could not be found";
    public const string CreateHotelDoesNotUniqueInfoResponseMessage = "Hotel with the requested info already exists";
}
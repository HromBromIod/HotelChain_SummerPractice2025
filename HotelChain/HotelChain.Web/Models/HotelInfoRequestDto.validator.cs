namespace HotelChain.Web.Models;

internal static class HotelInfoRequestDtoValidator
{
    private static readonly ValidationResult NullRequestErrorResult = new(false, 400, "Request is null");
    private static readonly ValidationResult InvalidIdErrorResult = new(false, 400, "Id must be greater then 0");
    private static readonly ValidationResult DefaultSuccessResult = new(true, 200, "Ok");
    public static ValidationResult Validate(this HotelInfoRequestDto? request)
    {
        if (request == null)
            return NullRequestErrorResult;

        if (request.Id < 0)
            return InvalidIdErrorResult;

        return DefaultSuccessResult;
    }
}
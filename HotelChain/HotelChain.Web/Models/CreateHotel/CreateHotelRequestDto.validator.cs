namespace HotelChain.Web.Models.CreateHotel;

internal static class CreateHotelRequestDtoValidator
{
    private static readonly ValidationResult NullRequestErrorResult = new(false, 400, "Request is null");
    private static readonly ValidationResult NullOrEmptyNameErrorResult = new(false, 400, "Name is null or empty");
    private static readonly ValidationResult NullOrEmptyPhoneNumberErrorResult = new(false, 400, "Phone number is null or empty");
    private static readonly ValidationResult InvalidPhoneNumberErrorResult = new(false, 400, "Phone number is null or empty");
    private static readonly ValidationResult NullOrEmptyEmailErrorResult = new(false, 400, "Email is null or empty");
    private static readonly ValidationResult NullOrEmptyAddressErrorResult = new(false, 400, "Address is null or empty");
    private static readonly ValidationResult DefaultSuccessResult = new(true, 200, "Ok");
    public static ValidationResult Validate(this CreateHotelRequestDto? request)
    {
        if (request == null)
            return NullRequestErrorResult;

        if (string.IsNullOrWhiteSpace(request.Name))
            return NullOrEmptyNameErrorResult;
        
        if (string.IsNullOrWhiteSpace(request.PhoneNumber))
            return NullOrEmptyPhoneNumberErrorResult;
        
        if (!request.PhoneNumber.All(char.IsDigit))
            return InvalidPhoneNumberErrorResult;
        
        if (string.IsNullOrWhiteSpace(request.Email))
            return NullOrEmptyEmailErrorResult;
        
        if (string.IsNullOrWhiteSpace(request.Address))
            return NullOrEmptyAddressErrorResult;

        return DefaultSuccessResult;
    }
}
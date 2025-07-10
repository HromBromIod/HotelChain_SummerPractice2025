namespace HotelChain.Web.Models;

internal record ValidationResult(
    bool IsValid,
    int StatusCode,
    string? ErrorMessage);
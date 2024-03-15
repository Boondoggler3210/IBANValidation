public enum ErrorCode
{
    EmptyOrTooShort,
    InvalidLength,
    InvalidFormat,
    InvalidModulus,
    InvalidCountryCode,
    InvalidCharacter,
}

public class ValidationError
{
    public ErrorCode Code { get; set; }
    public string? Message { get; set; }
}
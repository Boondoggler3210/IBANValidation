public enum ErrorCode
{
    EmptyOrTooShort,
    InvalidLength,
    InvalidFormat,
    InvalidModulus,
    InvalidCountryCode
}

public class ValidationError
{
    public ErrorCode Code { get; set; }
    public string? Message { get; set; }
}
namespace Iban;

public class ValidationResult
{
    public bool IsValid { get; set; }
    
    public List<ValidationError> Errors { get; set; } = new List<ValidationError>();

}

public class LengthCheckResult
{
    public bool IsValid { get; set; }
    public ValidationError? Error { get; set; }
}

public class ModulusCheckResult
{
    public bool IsValid { get; set; }
    public ValidationError? Error { get; set; }
}

public class FormatCheckResult
{
    public bool IsValid { get; set; }
    public ValidationError? Error { get; set; }
}


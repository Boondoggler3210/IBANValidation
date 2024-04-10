using IBANValidation.Validators.IBAN;

namespace IBANValidation.Validators
{
    public interface IReferenceOrAccountValidator
    {
        ValidationResult Validate(string referenceOrAccount);

    }
}
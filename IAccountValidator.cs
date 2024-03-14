namespace Iban
{
    public interface IReferenceOrAccountValidator
    {
        ValidationResult Validate(string referenceOrAccount);
        string CalculateCheckCharacters(string referenceOrAccount);

    }
}
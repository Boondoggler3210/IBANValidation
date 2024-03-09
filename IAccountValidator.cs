namespace Iban
{
    public interface IAccountValidator
    {
        ValidationResult Validate(string account);
    }
}
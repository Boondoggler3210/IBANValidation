namespace Iban
{
    public interface ICheckCharacterCalculator
    {
        string CalculateCheckCharacters(string referenceOrAccount);
    }
}
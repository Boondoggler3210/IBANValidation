namespace IBANValidation.CheckCharacterSystems
{
    public interface ICheckCharacterCalculator
    {
        string CalculateCheckCharacters(string referenceOrAccount);
    }
}
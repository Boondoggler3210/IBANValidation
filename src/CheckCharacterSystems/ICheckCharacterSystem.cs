namespace CheckCharacterSystems
{
    public interface ICheckCharacterSystem
    {
        bool Validate(string referenceIncludingCheckCharacters);
        string Calculate(string referenceWithoutCheckCharacters);
    }
}
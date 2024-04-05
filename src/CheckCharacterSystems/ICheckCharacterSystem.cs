namespace CheckCharacterSystems
{
    public interface ICheckCharacterSystem
    {
        bool Validate(string referenceWithoutCheckCharacters);
        string Calculate(string referenceIncludingCheckCharacters);
    }
}
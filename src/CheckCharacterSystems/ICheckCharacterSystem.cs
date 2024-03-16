namespace CheckCharacterSystems
{
    public interface ICheckCharacterSystem
    {
        bool Validate(string reference);
        string Calculate(string reference);
    }
}
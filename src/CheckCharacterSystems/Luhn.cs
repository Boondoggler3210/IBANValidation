using CheckCharacterSystems;

namespace IBANValidation.CheckCharacterSystems
{
    public class Luhn : ICheckCharacterSystem
    {
        public string Calculate(string referenceWithoutCheckCharacters)
        {
            var sum = 0;
            var doubleTheValue = true;
            for (var i = referenceWithoutCheckCharacters.Length - 1; i >= 0; i--)
            {
                var currentDigit = (Int32)Char.GetNumericValue(referenceWithoutCheckCharacters, i);
                if (doubleTheValue)
                {
                    if (currentDigit > 4)
                    {
                        sum += currentDigit * 2 - 9;
                    }
                    else
                    {
                        sum += currentDigit * 2;
                    }
                }
                else
                {
                    sum += currentDigit;
                }
                doubleTheValue = !doubleTheValue;
            }
            var checkDigit = 10 - (sum % 10);

            return checkDigit.ToString();
        }

        public bool Validate(string referenceIncludingCheckCharacters)
        {
            var luhn = new Luhn();
            var checkCharacter = luhn.Calculate(referenceIncludingCheckCharacters.Substring(0, referenceIncludingCheckCharacters.Length - 1));
            
            return referenceIncludingCheckCharacters[^1] == checkCharacter[0];

        }

 
    }
}


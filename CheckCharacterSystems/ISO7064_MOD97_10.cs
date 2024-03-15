using System.Numerics;

namespace CheckCharacterSystems
{
    public class ISO7064_MOD97_10 : ICheckCharacterSystem
    {
        public bool Validate(string reference)
        {
            var modulusResult = ConvertToBigInteger(reference) % 97;
        
            if (modulusResult == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Calculate(string reference)
        {
            var modulusResult = ConvertToBigInteger(reference) % 97;
        
            if(98 - (int)modulusResult >= 10)
            {
                return (98 - (int)modulusResult).ToString();
            }
            else
            {
                return "0" + (98 - (int)modulusResult).ToString();
            }
        }

        private static BigInteger ConvertToBigInteger(string reference)
        {
            string _reference = reference;
            if(string.IsNullOrEmpty(_reference))
            {
                throw new ArgumentException("IBAN is empty or too short");
            }

            
            string referenceAsInteger = "";

            foreach(var c in _reference)
            {
                int value = 0;
                if(char.IsLetterOrDigit(c) == false)
                {
                    BigInteger illegalCharacterResult = -1;
                    return illegalCharacterResult;
                }
                else if(char.IsLetter(c))
                {   
                    var letter = char.ToUpper(c);
                    value = letter - 55;
                }
                else
                {
                    value = int.Parse(c.ToString());
                }
                referenceAsInteger += value.ToString();
            }
            
            if(BigInteger.TryParse(referenceAsInteger, out BigInteger result))
            {
                return result;
            }
            else
            {
                result = -1;
                return result;
            }
        }
    }
}
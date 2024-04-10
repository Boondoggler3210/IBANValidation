using IBANValidation.CheckCharacterSystems;
using IBANValidation.Validators.IBAN;

namespace IBANValidation.Validators.USRoutingNumber;

public class USRoutingNumberValidator : IReferenceOrAccountValidator, ICheckCharacterCalculator
{
    public string CalculateCheckCharacters(string referenceOrAccount)
    {
        var _referenceOrAccount = referenceOrAccount;
        if (string.IsNullOrEmpty(_referenceOrAccount) || _referenceOrAccount.Length != 8)
        {
            return "";
        }

        int[] routingCodeAsIntArray = new int[9];
        int count = 0;
        foreach (char c in _referenceOrAccount)
        {
            if (!char.IsDigit(c))
            {
                return "";
            }

            routingCodeAsIntArray[count] = (int)char.GetNumericValue(c);
            count++;

        }
        var total = 3 * (routingCodeAsIntArray[0] + routingCodeAsIntArray[3] + routingCodeAsIntArray[6]) + 7 * (routingCodeAsIntArray[1] + routingCodeAsIntArray[4] + routingCodeAsIntArray[7]) + routingCodeAsIntArray[2] + routingCodeAsIntArray[5];
        if (total % 10 == 0)
        {
            return "0";
        }
        var checkDigit = 10 - total % 10;
        return checkDigit.ToString();
    }

    public ValidationResult Validate(string referenceOrAccount)
    {
        var _referenceOrAccount = referenceOrAccount;
        if (string.IsNullOrEmpty(_referenceOrAccount) || _referenceOrAccount.Length != 9)
        {
            return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidLength, Message = "US Routing Number must be 9 digits in length." } } };
        }

        if (_referenceOrAccount.Any(c => !char.IsDigit(c)))
        {
            return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidCharacter, Message = "US Routing Number must be numeric." } } };
        }

        if (USRoutingNumberData.Prefixes.Contains(_referenceOrAccount.Substring(0, 2)) == false)
        {
            return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidPrefix, Message = "US Routing Number must start with a valid prefix." } } };
        }

        int[] routingCodeAsIntArray = new int[9];
        int count = 0;
        foreach (char c in _referenceOrAccount)
        {
            if (!char.IsDigit(c))
            {
                return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidCharacter, Message = "US Routing Number must be numeric." } } };
            }

            routingCodeAsIntArray[count] = (int)char.GetNumericValue(c);
            count++;

        }
        var modulus = (3 * (routingCodeAsIntArray[0] + routingCodeAsIntArray[3] + routingCodeAsIntArray[6]) + 7 * (routingCodeAsIntArray[1] + routingCodeAsIntArray[4] + routingCodeAsIntArray[7]) + routingCodeAsIntArray[2] + routingCodeAsIntArray[5] + routingCodeAsIntArray[8]) % 10;

        if (modulus != 0)
        {
            return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidModulus, Message = "US Routing Number failed modulus check." } } };
        }
        else
        {
            return new ValidationResult { IsValid = true };
        }

    }
}
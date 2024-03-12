using CheckCharacterSystems;
using Iban;

namespace RFCreditorReference;

public class RFCreditorReferenceValidator : IAccountValidator
{
    public ValidationResult Validate(string rFCreditorReference)
    {
        string _rFCreditorReference = rFCreditorReference;
        var _result = new ValidationResult();
        _result.IsValid = true;
        if (string.IsNullOrEmpty(_rFCreditorReference) || _rFCreditorReference.Length < 5 || _rFCreditorReference.Length > 25)
        {
            _result.IsValid = false;
            _result.Errors.Add(new ValidationError { Code = ErrorCode.InvalidLength, Message = "RFCreditorReference must be between 5 and 25 Characters in length." });
            return _result;
        }

        var modulusCheckResult = CheckModulus(_rFCreditorReference);
        if (modulusCheckResult.IsValid == false)
        {
            _result.IsValid = false;
            _result.Errors.Add(modulusCheckResult.Error);
        }

        return _result;
    }

    private static ModulusCheckResult CheckModulus(string rFCreditorReference)
    {
        var _result = new ModulusCheckResult();
        if (string.IsNullOrEmpty(rFCreditorReference) || rFCreditorReference.Length < 5 || rFCreditorReference.Length > 25)
        {
            _result.IsValid = false;
            _result.Error = new ValidationError { Code = ErrorCode.InvalidLength, Message = "RFCreditorReference must be between 5 and 25 Characters in length." };
            return _result;
        }

        string _rFCreditorReference = rFCreditorReference;
           
        string firstFour = _rFCreditorReference.Substring(0, 4);
        _rFCreditorReference = _rFCreditorReference.Remove(0, 4);
        _rFCreditorReference += firstFour;
        
        var modulusResult = new ISO7064_MOD9710();
        
        if (modulusResult.Validate(_rFCreditorReference) == true)
        {
            _result.IsValid = true;
            return _result;
        }
        else
        {
            _result.IsValid = false;
            _result.Error = new ValidationError{Code = ErrorCode.InvalidModulus, Message = "mod 97-10 check failed."};
            var checkDigits = CalculateCheckDigits(rFCreditorReference);
            Console.WriteLine(_rFCreditorReference.Substring(0,_rFCreditorReference.Length - 4));
            _result.Error.Message += $" Correct check digits for this IBAN are {checkDigits}";
            return _result;
        }
        
    }
    public static string CalculateCheckDigits(string reference)
    {
        string _reference = reference;
        if(string.IsNullOrEmpty(_reference) || _reference.Length < 2)
        {
            throw new ArgumentException("Refernce is empty or too short");
        }

        string firstFour = _reference.Substring(0, 2);
        firstFour += "00";
        _reference = _reference.Remove(0, 4);
        _reference += firstFour;

        var checkdigits = new ISO7064_MOD9710().Calculate(_reference);
        return checkdigits;
    }
}
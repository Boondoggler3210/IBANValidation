using System.Numerics;
using System.Text.RegularExpressions;
using Iban.Data;

namespace Iban;

public class IbanValidator : IAccountValidator
{   

    public ValidationResult Validate(string iban, bool checkFormat = false)
    {
        bool _checkFormat = checkFormat;

        var result = new ValidationResult();
        result.IsValid = true;

        if(string.IsNullOrEmpty(iban) || iban.Length < 2)
        {
            result.IsValid = false;
            result.Errors.Add(new ValidationError{Code = ErrorCode.EmptyOrTooShort, Message = "IBAN is empty or too short"});
            return result;
        }

        var lengthCheckResult = CheckLength(iban);
        if(lengthCheckResult.IsValid == false)
        {
            result.IsValid = false;
            result.Errors.Add(lengthCheckResult.Error);
        }

        if(result.IsValid == true)
        {
            var modulusCheckResult = CheckModulus(iban);
            if(modulusCheckResult.IsValid == false)
            {
                result.IsValid = false;
                result.Errors.Add(modulusCheckResult.Error);
            }
        }
        
        if(checkFormat)
        {
            var formatCheckResult = CheckFormat(iban);
            if(formatCheckResult.IsValid == false)
            {
                result.IsValid = false;
                result.Errors.Add(formatCheckResult.Error);
            }
        }
        
        return result;
    }

    private static LengthCheckResult CheckLength(string iban)
    {
        var _result = new LengthCheckResult();
        if(string.IsNullOrEmpty(iban) || iban.Length < 2)
        {
            _result.IsValid = false;
            _result.Error = new ValidationError{Code = ErrorCode.EmptyOrTooShort, Message = "IBAN is empty or too short"};
            return _result;
        }
        
        int length;
        string countryCode = iban.Substring(0, 2);

        if (IbanData.Lengths.TryGetValue(countryCode, out length))
        {
            if (iban.Length == length)
            {
                _result.IsValid = true;
                return _result;
            }
            else
            {
                _result.IsValid = false;
                _result.Error = new ValidationError{Code = ErrorCode.InvalidLength, Message = $"IBAN length is valid for country code {countryCode}"} ;
                return _result;
            }
        }
        else
        {
            _result.IsValid = false;
            _result.Error = new ValidationError{Code = ErrorCode.InvalidCountryCode, Message = "Invalid country code"};
            return _result;
        }

    }

    private static ModulusCheckResult CheckModulus(string iban)
    {
        ModulusCheckResult result = new ModulusCheckResult();
        string _iban = iban;
        if(string.IsNullOrEmpty(iban) || iban.Length < 2)
        {
            result.IsValid = false;
            result.Error = new ValidationError{Code = ErrorCode.EmptyOrTooShort, Message = "IBAN is empty or too short"};
            return result;
        }
           
        string firstFour = _iban.Substring(0, 4);
        _iban = _iban.Remove(0, 4);
        _iban += firstFour;
        
        var modulusResult = ConvertIbanToBigInteger(_iban) % 97;
        
        if (modulusResult == 1)
        {
            result.IsValid = true;
            return result;
        }
        else
        {
            result.IsValid = false;
            result.Error = new ValidationError{Code = ErrorCode.InvalidModulus, Message = "mod 97-10 check failed."};
            var checkDigits = CalculateCheckDigits(iban);
            result.Error.Message += $" Correct check digits for this IBAN are {checkDigits}";
            return result;
        }
    }

    private static FormatCheckResult CheckFormat(string iban)
    {
        var result = new FormatCheckResult();
        if(string.IsNullOrEmpty(iban) || iban.Length < 2)
        {
            result.IsValid = false;
            result.Error = new ValidationError{Code = ErrorCode.EmptyOrTooShort, Message = "IBAN is empty or Too short"};
            return result;
        }

        IbanCountryData countryData;
        if(IbanData.CountryData.TryGetValue(iban.Substring(0, 2), out countryData))
        {
            if (Regex.IsMatch(iban, countryData.IBANFormatRegex))
            {
                result.IsValid = true;
                return result;
            }
            else
            {
                result.IsValid = false;
                result.Error = new ValidationError{Code = ErrorCode.InvalidFormat, Message = $"IBAN format is not valid for country code {countryData.CountryCode}"};
                return result;
            }
        }
        else
        {
            result.IsValid = false;
            result.Error = new ValidationError{Code = ErrorCode.InvalidCountryCode, Message = "Invalid country code"};
            return result;
        }
        
    }

    public static string CalculateCheckDigits(string iban)
    {
        string _iban = iban;
        if(string.IsNullOrEmpty(_iban) || _iban.Length < 2)
        {
            throw new ArgumentException("IBAN is empty or too short");
        }

        string firstFour = _iban.Substring(0, 2);
        firstFour += "00";
        _iban = _iban.Remove(0, 4);
        _iban += firstFour;
        
        var modulusResult = ConvertIbanToBigInteger(_iban) % 97;
        
        if(98 - (int)modulusResult >= 10)
        {
            return (98 - (int)modulusResult).ToString();
        }
        else
        {
            return "0" + (98 - (int)modulusResult).ToString();
        }

    }

    private static BigInteger ConvertIbanToBigInteger(string iban)
    {
        string _iban = iban;
        if(string.IsNullOrEmpty(_iban) || _iban.Length < 2)
        {
            throw new ArgumentException("IBAN is empty or too short");
        }

        
        string ibanAsInteger = "";

        foreach(var c in _iban)
        {
            int value = 0;
            if (char.IsLetter(c))
            {   
                var letter = char.ToUpper(c);
                value = letter - 55;
            }
            else
            {
                value = int.Parse(c.ToString());
            }
            ibanAsInteger += value.ToString();
        }
        
        if(BigInteger.TryParse(ibanAsInteger, out BigInteger result))
        {
            return result;
        }
        else
        {
            throw new ArgumentException("IBAN is too long to be converted to BigInteger");
        }

    }

}


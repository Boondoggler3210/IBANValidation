using System.Text.RegularExpressions;
using Iban;
using Bic.Data;

namespace Bic;

public class BicValidator : IAccountValidator 
{
    public ValidationResult Validate(string bic)
    {
        string _bic = bic;
        var _result = new ValidationResult();
        _result.IsValid = true;
        if(string.IsNullOrEmpty(_bic) || (_bic.Length != 8 && _bic.Length != 11))
        {
            _result.IsValid = false;
            _result.Errors.Add(new ValidationError{Code = ErrorCode.InvalidLength, Message = "BIC must be 8 or 11 Characters in length."});
            return _result;
        }

        if(_bic.Length == 11)
        {
            if(!Regex.IsMatch(_bic,"[A-Z]{4}[A-Z]{2}[A-Z0-9]{2}[A-z0-9]{3}$"))
            {
                _result.IsValid = false;
                _result.Errors.Add(new ValidationError{Code = ErrorCode.InvalidFormat, Message = "BIC format is invalid."});
                return _result;
            }
        }
        else
        {
            if(!Regex.IsMatch(_bic,"[A-Z]{4}[A-Z]{2}[A-Z0-9]{2}$"))
            {
                _result.IsValid = false;
                _result.Errors.Add(new ValidationError{Code = ErrorCode.InvalidFormat, Message = "BIC format is invalid."});
                return _result;
            }
        }
            
        var countryCodeCheckResult = CheckCountryCode(_bic);
        if(countryCodeCheckResult.IsValid == false)
        {
            _result.IsValid = false;
            _result.Errors.Add(countryCodeCheckResult.Error);
        }
        return _result;
    }

    private static FormatCheckResult CheckCountryCode(string bic)
    {
        string _bic = bic;
        FormatCheckResult _result = new FormatCheckResult();
        _result.IsValid = true;

        if(string.IsNullOrEmpty(bic) || (bic.Length != 8 && bic.Length != 11))
        {
            _result.IsValid = false;
            _result.Error = new ValidationError{Code = ErrorCode.InvalidLength, Message = "BIC must be 8 or 11 Characters in length."};
            return _result;
        }

        if(!IsoCountryCodes.CountryCodes.Contains(_bic.Substring(4,2)))
        {
            _result.IsValid = false;
            _result.Error = new ValidationError{Code = ErrorCode.InvalidCountryCode, Message = "Characters 5 and 6 must be a valid ISO country code."};
            return _result;
        }
        return _result;
    }

}
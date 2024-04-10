using Iban;
using IBANValidation.CheckCharacterSystems;

namespace IBANValidation.TaxIdentificationNumbers.UKVATRegistrationNumber
{
    public class UKVATRegistrationNumberValidator : IReferenceOrAccountValidator
    {
        private readonly int[] _validLengths = { 5, 7, 9, 11, 12, 14 };
        private readonly int[] _lengthsThatMustIncludeCountryCode = { 7, 11, 14 };
        public ValidationResult Validate(string uKVATRegistrationNumber)
        {

            var _uKVATRegistrationNumber = uKVATRegistrationNumber.Replace(" ", string.Empty);
            _uKVATRegistrationNumber = _uKVATRegistrationNumber.Replace("-", string.Empty);

            if (string.IsNullOrEmpty(_uKVATRegistrationNumber))
            {
                return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidLength, Message = "UK VAT Registration Number must be 9 Characters in length." } } };
            }

            if (!_uKVATRegistrationNumber.All(char.IsLetterOrDigit))
            {
                return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidFormat, Message = "UK VAT Registration Number must contain only letters and numbers." } } };
            }

            if (!_validLengths.Contains(_uKVATRegistrationNumber.Length))
            {
                return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidLength, Message = "UK VAT Registration Number must be 5, 7, 9, 11, 12 or 14 Characters in length." } } };
            }

            if (_lengthsThatMustIncludeCountryCode.Contains(_uKVATRegistrationNumber.Length) && _uKVATRegistrationNumber.Substring(0, 2) != "GB")
            {
                return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidPrefix, Message = "7, 11 and 14  Character UK VAT Registration Number must start with GB" } } };
            }

            var _reference = "";

            switch (_uKVATRegistrationNumber.Length)
            {
                case 14:
                case 11:
                    _reference = _uKVATRegistrationNumber.Substring(2, 9);
                    break;
                case 12:
                    _reference = _uKVATRegistrationNumber.Substring(0, 9);
                    break;
                case 7:
                    if (!ValidateFiveCharacterUKVATRegistrationNumber(_uKVATRegistrationNumber.Substring(2, 5)))
                    {
                        return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidFormat, Message = "Government Derpartment or Health Authority VAT Registration number format or range is invalid." } } };
                    }
                    else
                    {
                        return new ValidationResult() { IsValid = true };
                    };
                case 5:
                    if (!ValidateFiveCharacterUKVATRegistrationNumber(_uKVATRegistrationNumber))
                    {
                        return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidFormat, Message = "Government Derpartment or Health Authority VAT Registration number format or range is invalid." } } };
                    }
                    else
                    {
                        return new ValidationResult() { IsValid = true };
                    };
                default:
                    _reference = _uKVATRegistrationNumber;
                    break;
            }

            var modulus1Result = new MOD97_DescendingFrom8().Validate(_reference);
            var modulus2Result = new MOD9755_DescendingFrom8().Validate(_reference);
            if (modulus1Result == false && modulus2Result == false)
            {
                return new ValidationResult { IsValid = false, Errors = new List<ValidationError> { new ValidationError { Code = ErrorCode.InvalidModulus, Message = "UK VAT Registration Number's check Digits are not valid." } } };
            }
            return new ValidationResult() { IsValid = true };

        }

        private bool ValidateFiveCharacterUKVATRegistrationNumber(string uKVATRegistrationNumber)
        {
            if (string.IsNullOrEmpty(uKVATRegistrationNumber) || uKVATRegistrationNumber.Length != 5)
            {
                return false;
            }

            string[] shortUKVATRegistrationNumberPrefixes = { "GD", "HA" };

            if (!shortUKVATRegistrationNumberPrefixes.Contains(uKVATRegistrationNumber.Substring(0, 2)))
            {
                return false;
            }

            if (!uKVATRegistrationNumber.Substring(2, 3).All(char.IsDigit))
            {
                return false;
            }

            var digits = int.Parse(uKVATRegistrationNumber.Substring(2, 3));

            if (uKVATRegistrationNumber.Substring(0, 2) == "GD")
            {
                if (!(digits >= 0 && digits <= 499))
                {
                    return false;
                }
            }
            else if (uKVATRegistrationNumber.Substring(0, 2) == "HA")
            {
                if (!(digits >= 500 && digits <= 999))
                {
                    return false;
                }
            }

            return true;
        }
    }


}


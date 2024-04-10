using IBANValidation.CheckCharacterSystems;
using IBANValidation.Validators.IBAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.Validators.NOOrganisasjonsnummer
{
    public class NOOrganisasjonsnummerValidator : IReferenceOrAccountValidator, ICheckCharacterCalculator
    {
        public string CalculateCheckCharacters(string referenceOrAccount)
        {

            var mod11CheckCharacterSystem = new MOD11(new int[] { 2, 3, 4, 5, 6, 7 }, ProcessingDirection.RightToLeft);
            return mod11CheckCharacterSystem.Calculate(referenceOrAccount);
        }

        public ValidationResult Validate(string referenceOrAccount)
        {
            string _referenceOrAccount = referenceOrAccount.Replace(" ", "");
            var _result = new ValidationResult();
            _result.IsValid = true;

            if (string.IsNullOrEmpty(_referenceOrAccount) || _referenceOrAccount.Length != 9)
            {
                _result.IsValid = false;
                _result.Errors.Add(new ValidationError { Code = ErrorCode.InvalidLength, Message = "Norwegian Organisasjonsnummer must be 9 digits long." });
                return _result;
            }

            if (_referenceOrAccount.Any(c => !char.IsDigit(c)))
            {
                _result.IsValid = false;
                _result.Errors.Add(new ValidationError { Code = ErrorCode.InvalidCharacter, Message = "Norwegian Organisasjonsnummer must be numeric." });
                return _result;
            }
            var mod11CheckSystem = new MOD11(new int[] { 2, 3, 4, 5, 6, 7 }, ProcessingDirection.RightToLeft);
            string _checkDigit = mod11CheckSystem.Calculate(_referenceOrAccount.Substring(0, _referenceOrAccount.Length - 1));
            if (_referenceOrAccount.Substring(_referenceOrAccount.Length - 1, 1) != _checkDigit)
            {
                _result.IsValid = false;
                _result.Errors.Add(new ValidationError { Code = ErrorCode.InvalidModulus, Message = $"Modulus Check failed. Check character should be {_checkDigit}" });
                return _result;
            }
            else
            {
                return _result;
            }
        }
    }


}


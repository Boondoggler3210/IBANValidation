using IBANValidation.CheckCharacterSystems;
using IBANValidation.Validators.IBAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.Validators.GlobalLocationNumber
{
    public class GlobalLocationNumberValidator : IReferenceOrAccountValidator, ICheckCharacterCalculator
    {
        public string CalculateCheckCharacters(string referenceOrAccount)
        {
            var gs1CheckCharacterSystem = new GS1_CheckCharacterSystem();
            return gs1CheckCharacterSystem.Calculate(referenceOrAccount);
        }

        public ValidationResult Validate(string referenceOrAccount)
        {
            string _referenceOrAccount = referenceOrAccount;
            var _result = new ValidationResult();
            _result.IsValid = true;

            if (string.IsNullOrEmpty(_referenceOrAccount) || _referenceOrAccount.Length != 13)
            {
                _result.IsValid = false;
                _result.Errors.Add(new ValidationError { Code = ErrorCode.InvalidLength, Message = "Global Location Number must be 13 Characters in length." });
                return _result;
            }

            if (_referenceOrAccount.Any(c => !char.IsDigit(c)))
            {
                _result.IsValid = false;
                _result.Errors.Add(new ValidationError { Code = ErrorCode.InvalidCharacter, Message = "Global Location Number must be numeric." });
                return _result;
            }
            var gs1CheckCharacterSystem = new GS1_CheckCharacterSystem();
            string _checkDigit = gs1CheckCharacterSystem.Calculate(_referenceOrAccount.Substring(0, _referenceOrAccount.Length - 1));
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

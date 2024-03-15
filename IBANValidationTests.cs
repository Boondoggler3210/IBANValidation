using Iban;

namespace IBANValidation.Tests
{
    public class IBANValidationTests
    {
        private readonly IbanValidator _ibanValidator;
        public IBANValidationTests()
        {
            _ibanValidator = new IbanValidator();
        }
        [Fact]
        public void IBANValidator_Validate_ReturnsFalseWhenIBANTooShort()
        {
            var result = _ibanValidator.Validate("GB");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.EmptyOrTooShort);
        }

        [Fact]
        public void IBANValidator_Validate_ReturnsFalseWhenIBANIsEmpty()
        {
            var result = _ibanValidator.Validate("");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.EmptyOrTooShort);
        }

        [Fact]
        public void IBANValidator_Validate_ReturnsFalseWhenIbanContainsInvalidCharacters()
        {
            var result = _ibanValidator.Validate("GB12!IDL67890123456789");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidCharacter);
        }

        [Fact]
        public void IBANValidator_Validate_ReturnsFalseWhenIbanContainsInvalidCountryCode()
        {
            var result = _ibanValidator.Validate("ZZ12IDL67890123456789");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidCountryCode);
        }

        [Theory]
        [ClassData(typeof(IbanTestDataInvalidLengthForCountry))]
        public void IBANValidator_Validate_ReturnsFalseWhenIBANInvalidLengthForCountry(string invalidLengthForCountry)
        {
            var result = _ibanValidator.Validate(invalidLengthForCountry);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [ClassData(typeof(IbanTestDataValidIbans))]
        public void IBANValidator_Validate_ReturnsTrueWhenIBANIsValid(string validIban)
        {
                var result = _ibanValidator.Validate(validIban);
                Assert.True(result.IsValid);
        }

        [Theory]
        [ClassData(typeof(IbanTestDataInvalidCheckChars))]
        public void IBANValidator_Validate_ReturnsFalseWhenIBANHasInvalidCheckChars(string invalidCheckChars)
        {
            var result = _ibanValidator.Validate(invalidCheckChars);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidModulus);
        }
    }
}

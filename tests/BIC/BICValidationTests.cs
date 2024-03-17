using Bic;
using Iban;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.Tests.BIC
{
    public class BICValidationTests
    {
        private readonly BicValidator _bicValidator;
        public BICValidationTests()
        {
            _bicValidator = new BicValidator();
        }

        [Fact]
        public void BICValidator_Validate_ReturnsFalseWhenBicTooShort()
        {
            var result = _bicValidator.Validate("DEUTDEF");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Fact]
        public void BICValidator_Validate_ReturnsFalseWhenBicIsEmpty()
        {
            var result = _bicValidator.Validate("");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }
        [Fact]
        public void BICValidator_Validate_ReturnsFalseWhenBicContainsInvalidCharacters()
        {
            var result = _bicValidator.Validate("RABONL_1");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidFormat);
        }

        [Theory]
        [InlineData("DEUTZZFF123")]
        [InlineData("DEUTZZFF")]
        [InlineData("RABOYYFF")]
        [InlineData("MIDLUKRR123")]
        public void BICValidator_Validate_ReturnsFalseWhenBicContainsInvalidCountryCode(string bic)
        {
            var result = _bicValidator.Validate(bic);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidCountryCode);
        }

        [Theory]
        [InlineData("DEUTDEFF")]
        [InlineData("DEUTDEFF123")]
        [InlineData("RABONL2U")]
        [InlineData("RABONL2U123")]
        [InlineData("MIDLGB22")]
        [InlineData("MIDLGB22XXX")]
        public void BICValidator_Validate_ReturnsTrueWhenBicIsValid(string bic)
        {
            var result = _bicValidator.Validate(bic);
            Assert.True(result.IsValid);
        }

    }
}


using IBANValidation.Validators.GlobalLocationNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.Tests.GlobalLocationNumber
{
    public class GlobalLocationNumberValidationTests
    {
        private readonly GlobalLocationNumberValidator _globalLocationNumberValidator;

        public GlobalLocationNumberValidationTests()
        {
            _globalLocationNumberValidator = new GlobalLocationNumberValidator();
        }

        [Theory]
        [InlineData("123")]
        [InlineData("1234")]
        [InlineData("12345")]
        [InlineData("123456")]
        [InlineData("1234567")]
        [InlineData("12345678")]
        [InlineData("123456789")]
        [InlineData("1234567890")]
        [InlineData("12345678901")]
        [InlineData("123456789012")]
        public void GlobalLocationNumberValidator_Validate_ReturnsFalseWhenReferenceTooShort(string reference)
        {
            var result = _globalLocationNumberValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [InlineData("12345678901234")]
        public void GlobalLocationNumberValidator_Validate_ReturnsFalseWhenReferenceTooLong(string reference)
        {
            var result = _globalLocationNumberValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Fact]
        public void GlobalLocationNumberValidator_Validate_ReturnsFalseWhenReferenceIsEmpty()
        {
            var result = _globalLocationNumberValidator.Validate("");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [InlineData("5060012349998")]
        [InlineData("0847976000005")]
        [InlineData("5012345000008")]
        [InlineData("5055123401239")]
        public void GlobalLocationNumberValidator_Validate_ReturnsTrueWhenReferenceIsValid(string reference)
        {
            var result = _globalLocationNumberValidator.Validate(reference);
            Assert.True(result.IsValid);
        }

        [Theory]
        [InlineData("506)(12349997")]
        [InlineData("08479760_!006")]
        public void GlobalLocationNumberValidator_Validate_ReturnsFalseWhenReferenceContainsNonNumericCharacters(string reference)
        {
            var result = _globalLocationNumberValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidCharacter);
        }

    }
}

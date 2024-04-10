using IBANValidation.Validators.RFCreditorReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.Tests.RFCreditorReference
{
    public class RFCreditorReferenceValidationTests
    {
        private readonly RFCreditorReferenceValidator _rfCreditorReferenceValidator;

        public RFCreditorReferenceValidationTests()
        {
            _rfCreditorReferenceValidator = new RFCreditorReferenceValidator();
        }

        [Theory]
        [InlineData("123")]
        [InlineData("RF18")]
        [InlineData("RF")]
        [InlineData("T")]

        public void RFCreditorReferenceValidator_Validate_ReturnsFalseWhenReferenceTooShort(string reference)
        {
            var result = _rfCreditorReferenceValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [InlineData("12345678911234567890123456")]
        [InlineData("RF1858439485679029256539288")]
        public void RFCreditorReferenceValidator_Validate_ReturnsFalseWhenReferenceTooLong(string reference)
        {
            var result = _rfCreditorReferenceValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Fact]
        public void RFCreditorReferenceValidator_Validate_ReturnsFalseWhenReferenceIsEmpty()
        {
            var result = _rfCreditorReferenceValidator.Validate("");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [ClassData(typeof(RFCreditorReferenceTestDataValidReferences))]
        public void RFCreditorReferenceValidator_Validate_ReturnsTrueWhenReferenceIsValid(string reference)
        {
            var result = _rfCreditorReferenceValidator.Validate(reference);
            Assert.True(result.IsValid);
        }

        [Theory]
        [InlineData("RF03539007547034")]
        [InlineData("RF18539007547036")]
        [InlineData("RF18539007547037")]
        [InlineData("RF18539007547038")]
        [InlineData("RF18539007547039")]
        public void RFCreditorReferenceValidator_Validate_ReturnsFalseWhenReferenceContainsInvalidCheckCharacters(string reference)
        {
            var result = _rfCreditorReferenceValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidModulus);
        }

        [Fact]
        public void RFCreditorReferenceValidator_Validate_ReturnsFalseWhenReferenceDoesNotStartWithRF()
        {
            var result = _rfCreditorReferenceValidator.Validate("R185390075");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidPrefix);
        }

        [Theory]
        [ClassData(typeof(RFCreditorReferenceTestDataRefAndExpectedRFRef))]
        public void RFCreditorReferenceValidator_CalculateCheckCharacters_ReturnsExpectedCheckCharacters(string expected, string reference)
        {
            var result = _rfCreditorReferenceValidator.CalculateReference(reference);
            Assert.Equal(expected, result);
        }

    }
}

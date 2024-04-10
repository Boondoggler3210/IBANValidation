using IBANValidation.GlobalLocationNumber;
using IBANValidation.NOOrganisasjonsnummer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.Tests.NOOrganisasjonsnummer
{
    public class NOOrganisasjonsnummerValidationTests
    {
        private readonly NOOrganisasjonsnummerValidator _nOOrganisasjonsnummerValidator;

        public NOOrganisasjonsnummerValidationTests()
        {
            _nOOrganisasjonsnummerValidator = new NOOrganisasjonsnummerValidator();
        }

        [Theory]
        [InlineData("123")]
        [InlineData("1234")]
        [InlineData("12345")]
        [InlineData("123456")]
        [InlineData("1234567")]
        [InlineData("12345678")]
        public void NOOrgansisasjonsnummerValidator_Validate_ReturnsFalseWhenReferenceTooShort(string reference)
        {
            var result = _nOOrganisasjonsnummerValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [InlineData("123456789012345")] 
        public void NOOrgansisasjonsnummerValidator_Validate_ReturnsFalseWhenReferenceTooLong(string reference)
        {
            var result = _nOOrganisasjonsnummerValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Fact]
        public void NOOrgansisasjonsnummerValidator_Validate_ReturnsFalseWhenReferenceIsEmpty()
        {
            var result = _nOOrganisasjonsnummerValidator.Validate("");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Fact]
        public void NOOrgansisasjonsnummerValidator_Validate_ReturnsFalseWhenReferenceContainsNonNumericCharacters()
        {
            var result = _nOOrganisasjonsnummerValidator.Validate("123456AAA");
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidCharacter);
        }

        [Theory]
        [InlineData("932 426 986")]
        [InlineData("932426986")]
        [InlineData("931 693 263")]
        [InlineData("931693263")]
        [InlineData("925 095 664")]
        [InlineData("925095664")]
        [InlineData("979 168 268")]
        [InlineData("979168268")]
        public void NOOrgansisasjonsnummerValidator_Validate_ReturnsTrueWhenReferenceIsValid(string reference)
        {
            var result = _nOOrganisasjonsnummerValidator.Validate(reference);
            Assert.True(result.IsValid);
        }
    }
}

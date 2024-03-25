using Iban;
using IBANValidation.UKVATRegistrationNumber;


namespace IBANValidation.Tests.UKVATRegistrationNumber
{
    public class UKVATRegistrationNumberTests
    {
        private readonly UKVATRegistrationNumberValidator _uKVATRegistrationNumberValidator;
        public UKVATRegistrationNumberTests()
        {
            _uKVATRegistrationNumberValidator = new UKVATRegistrationNumberValidator();
        }

        [Theory]
        [InlineData("GB")]
        [InlineData("GB12")]
        [InlineData("123456")]
        [InlineData("GB123456")]
        [InlineData("12345678")]
        [InlineData("GB12345678")]
        [InlineData("1234567891")]
        [InlineData("123456789123456")]
        public void UKVATRegistrationNumberValidator_Validate_ReturnsFalseWhenUKVATRegInvalidLength(string vATReg)
        {
            var result = _uKVATRegistrationNumberValidator.Validate(vATReg);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [InlineData("NL1234567")]
        [InlineData("ES1234567")]
        [InlineData("FR1234567")]
        [InlineData("DE1234567")]
        [InlineData("IT1234567")]
        [InlineData("BE1234567")]
        [InlineData("LU1234567")]
        public void UKVATRegistrationNumberValidator_Validate_ReturnsFalseWhenUKVATRegInvalidPrefix(string vATReg)
        {
            var result = _uKVATRegistrationNumberValidator.Validate(vATReg);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidPrefix);
        }

        [Theory]
        [InlineData("GB123_4567")]
        [InlineData("GB1234567")]
        [InlineData("GB123A5678")]
        [InlineData("GB123456XXX")]
        [InlineData("GB!23456789123")]
        [InlineData("GB12_3456789123456")]

        public void UKVATRegistrationNumberValidator_Validate_ReturnsFalseWhenUKVATRegInvalidFormat(string vATReg)
        {
            var result = _uKVATRegistrationNumberValidator.Validate(vATReg);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidFormat);
        }

        [Theory]
        [InlineData("GBHA123")]
        [InlineData("GBGD891")]
        public void UKVATRegistrationNumberValidator_Validate_ReturnsFalseWhenWrongNumericRangeIsUsedForGovernmentDepartmentOrHealthAuthority(string vATReg)
        {
            var result = _uKVATRegistrationNumberValidator.Validate(vATReg);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidFormat);
        }

        [Theory]
        [InlineData("GB220 4302 31")]
        [InlineData("660454836")]
        [InlineData("125688644")]
        [InlineData("GBGD123")]
        [InlineData("GBHA599")]

        public void UKVATRegistrationNumberValidator_Validate_ReturnsTrueWhenUKVATRegIsValid(string vATReg)
        {
            var result = _uKVATRegistrationNumberValidator.Validate(vATReg);
            Assert.True(result.IsValid);
        }
    }
}

using IBANValidation.Validators.USRoutingNumber;

namespace IBANValidation.Tests.USRoutingNumber
{
    public class USRoutingNumberValidationTests
    {
        private readonly USRoutingNumberValidator _usRoutingNumberValidator;

        public USRoutingNumberValidationTests()
        {
            _usRoutingNumberValidator = new USRoutingNumberValidator();
        }

        [Theory]
        [InlineData("123")]
        [InlineData("1234567891")]
        [InlineData("T")]
        [InlineData("12345678")]
        public void USRoutingNumberValidator_Validate_ReturnsFalseWhenReferenceIsWrongLength(string reference)
        {
            var result = _usRoutingNumberValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidLength);
        }

        [Theory]
        [InlineData("133456789")]
        [InlineData("143456789")]
        [InlineData("153456789")]
        [InlineData("163456789")]
        [InlineData("173456789")]
        [InlineData("183456789")]
        [InlineData("193456789")]
        [InlineData("203456789")]
        [InlineData("333456789")]
        [InlineData("343456789")]
        [InlineData("353456789")]
        [InlineData("363456789")]
        [InlineData("373456789")]
        [InlineData("383456789")]
        [InlineData("393456789")]
        [InlineData("403456789")]
        [InlineData("513456789")]
        [InlineData("523456789")]
        [InlineData("533456789")]
        [InlineData("543456789")]
        [InlineData("553456789")]
        [InlineData("563456789")]
        [InlineData("573456789")]
        [InlineData("583456789")]
        [InlineData("593456789")]
        [InlineData("603456789")]
        [InlineData("733456789")]
        [InlineData("743456789")]
        [InlineData("753456789")]
        [InlineData("763456789")]
        [InlineData("773456789")]
        [InlineData("783456789")]
        [InlineData("793456789")]
        public void USRoutingNumberValidator_Validate_ReturnsFalseWhenReferenceContainsInvalidPrefix(string reference)
        {
            var result = _usRoutingNumberValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidPrefix);
        }

        [Theory]
        [ClassData(typeof(USRoutingNumberTestDataValidRoutingNumbers))]
        public void USRoutingNumberValidator_Validate_ReturnsTrueWhenReferenceIsValid(string reference)
        {
            var result = _usRoutingNumberValidator.Validate(reference);
            Assert.True(result.IsValid);
        }

        [Theory]
        [ClassData(typeof(USRoutingNumberTestDataValidRoutingNumbers))]
        public void USRoutingNumberValidator_CalculateCheckCharacters_ReturnsCorrectCheckCharacter(string reference)
        {
            var result = _usRoutingNumberValidator.CalculateCheckCharacters(reference.Substring(0,8));
            Assert.Equal(result, reference.Substring(8, 1));
        }

        [Theory]
        [ClassData(typeof(USRoutingNumberTestDataInvalidCheckCharacters))]
        public void USRoutingNumberValidator_Validate_ReturnsFalseWhenReferenceContainsInvalidCheckCharacter(string reference)
        {
            var result = _usRoutingNumberValidator.Validate(reference);
            Assert.False(result.IsValid);
            Assert.Contains(result.Errors, e => e.Code == ErrorCode.InvalidModulus);
        }


    }
}

using ExcelUtilities.Exceptions;
using Xunit;

namespace PeselUtilities.Tests
{
    public class PeselValidationsTests
    {
        [Theory]
        [InlineData("qwertyuiop")]
        [InlineData("123456789123")]
        public void ValidatePeselLengthInCell_For_PeselString_Throws_InvalidPeselFormat(string peselString)
        {
            Assert.Throws<InvalidPeselFormat>(() => PeselValidations.ValidatePeselFormat(peselString, "A0"));
        }

        [Fact]
        public void ValidateMonthLenghtByYear_For_PeselFactors_Assert_InvalidDaysNumberInMonth()
        {
            // Arrange
            var peselFactors = new PeselFactors
            {
                Day = 31,
                Month = 9,
                Year = 1990,
                OtherElements = "69222"
            };

            // Assert
            Assert.Throws<InvalidDaysNumberInMonth>(() => PeselValidations.ValidateMonthLenghtByYear(peselFactors, "A0"));
        }


        [Theory]
        [InlineData("one")]
        [InlineData("123456789")]
        public void IsPeselLengthCorrect_For_PeselString_Assert_False(string peselString)
        {
            Assert.False(PeselValidations.IsPeselLengthCorrect(peselString));
        }

        [Theory]
        [InlineData("one")]
        [InlineData("one2345six")]
        public void IsNumber_For_Input_Assert_False(string input)
        {
            Assert.False(PeselValidations.IsNumber(input));
        }
    }
}

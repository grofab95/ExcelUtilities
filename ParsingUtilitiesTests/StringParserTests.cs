using ParsingUtilities;
using System;
using Xunit;

namespace ParsingUtilitiesTests
{
    public class StringParserTests
    {
        [Fact]
        public void StringToDouble_For_UserInput_Throws_FormatException()
        {
            Assert.Throws<FormatException>(() => StringParser.StringToDouble("one"));
        }

        [Fact]
        public void StringToDouble_For_UserInput_Assert_DoubleType()
        {
            // Arrange
            var actual = StringParser.StringToDouble("2").GetType();
            var expected = typeof(double);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void StringToInt_For_UserInput_Throws_FormatException()
        {
            Assert.Throws<FormatException>(() => StringParser.StringToInt("one"));
        }

        [Fact]
        public void StringToInt_For_UserInput_Assert_IntNumber()
        {
            // Arrange
            var actual = StringParser.StringToInt("1").GetType();
            var expected = typeof(int);

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}

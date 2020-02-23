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
            Assert.IsType<double>(StringParser.StringToDouble("one"));
        }

        [Fact]
        public void StringToInt_For_UserInput_Throws_FormatException()
        {
            Assert.Throws<FormatException>(() => StringParser.StringToInt("one"));
        }

        [Fact]
        public void StringToInt_For_UserInput_Assert_IntNumber()
        {
            Assert.IsType<int>(StringParser.StringToInt("one"));
        }
    }
}

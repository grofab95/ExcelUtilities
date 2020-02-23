using PeselUtilities.Helpers;
using Xunit;

namespace PeselUtilities.Tests
{
    public class MonthConfigTests
    {
        [Theory]
        [InlineData(2016)]
        [InlineData(2020)]
        public void IsLeapYear_For_IndexerMonthLengthWhenLeapYear_Equal_29(int year)
        {
            // Arrange
            var monthsConfig = new MonthsConfig(year);

            // Assert
            Assert.Equal<int>(29, monthsConfig[2]);
        }
    }
}

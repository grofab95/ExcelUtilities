using Xunit;

namespace PeselUtilities.Tests
{
    public class PeselNumberTranslatorTests
    {
        [Theory]
        [InlineData("94101396696")]
        [InlineData("94101306696")]
        public void ExtractOtherPeselElements_For_ReturnedElementsAmount_Equal_Five(string pesel)
        {
            // Arrange
            var otherPeselElements = PeselNumberTranslator.ExtractOtherPeselElements(pesel);
            var otherPeselElementsAmount = otherPeselElements.Length;

            // Assert
            Assert.Equal<int>(5, otherPeselElementsAmount);
        }
    }
}

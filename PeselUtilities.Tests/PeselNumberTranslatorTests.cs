using Xunit;

namespace PeselUtilities.Tests
{
    public class PeselNumberTranslatorTests
    {
        [Fact]
        public void ExtractOtherPeselNumbers_For_ReturnedNumbersAmount_Equal_Five()
        {
            Assert.Equal<int>(5, PeselNumberTranslator.ExtractOtherPeselNumbers("95072686696"));
        }
    }
}

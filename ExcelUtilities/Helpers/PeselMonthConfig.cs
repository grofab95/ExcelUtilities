using ExcelUtilities.Enums;
using ExcelUtilities.Exceptions;

namespace ExcelUtilities.Helpers
{
    public class PeselMonthConfig
    {
        private PeselFactors _peselFactors;
        
        public PeselMonthConfig(PeselFactors peselFactors)
        {
            _peselFactors = peselFactors;
            ChangePeselFactors();
        }

        public PeselFactors GetCorrectPeselFactors()
            => _peselFactors;

        private PeselYearRangesNames CheckYearRangeUsingMonth()
        {
            if (_peselFactors.Month >= 81 && _peselFactors.Month <= 92)
            {
                return PeselYearRangesNames.YearInRange1800And1899;
            }

            if (_peselFactors.Month >= 1 && _peselFactors.Month <= 12)
            {
                return PeselYearRangesNames.YearInRange1900And1999;
            }

            if (_peselFactors.Month >= 21 && _peselFactors.Month <= 32)
            {
                return PeselYearRangesNames.YearInRange2000And2099;
            }

            throw new InvalidYearRange(_peselFactors.Month);
        }

        private void ChangePeselFactors()
        {
            switch (CheckYearRangeUsingMonth())
            {
                case PeselYearRangesNames.YearInRange1800And1899:
                    _peselFactors.Month = 
                        PeselMonthTranslator.GetCorrectMonth(
                            _peselFactors.Month, PeselYearRangesNames.YearInRange1800And1899);
                    _peselFactors.Year = int.Parse("18" + _peselFactors.Year.ToString());
                    break;
                case PeselYearRangesNames.YearInRange1900And1999:
                    _peselFactors.Year = int.Parse("19" + _peselFactors.Year.ToString());
                    break;
                case PeselYearRangesNames.YearInRange2000And2099:
                    _peselFactors.Month =
                        PeselMonthTranslator.GetCorrectMonth(
                            _peselFactors.Month, PeselYearRangesNames.YearInRange2000And2099);
                    _peselFactors.Year = int.Parse("20" + _peselFactors.Year.ToString());
                    break;
            }
        }
    }
}

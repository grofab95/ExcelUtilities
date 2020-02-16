using PeselUtilities.Helpers;

namespace PeselUtilities
{
    public class PeselSimpleValidations
    {
        private PeselFactors _peselFactors;

        public PeselSimpleValidations(PeselFactors peselFactors)
        {
            _peselFactors = 
                new PeselMonthTranslator(peselFactors, Enums.ReturnTypeWhenStWrong.Enum).GetCorrectPeselFactors();

        }

        public bool IsBornDateCorrect()
        {
            var qqqqq = IsMonthNumberCorrect();
            return IsMonthNumberCorrect() && IsCorrectNumberOfMonthDays();
        }
        

        private bool IsMonthNumberCorrect()
        {
            if (_peselFactors.Month >= 81 && _peselFactors.Month <= 92)
            {
                return true;
            }

            if (_peselFactors.Month >= 1 && _peselFactors.Month <= 12)
            {
                return true;
            }

            if (_peselFactors.Month >= 21 && _peselFactors.Month <= 32)
            {
                return true;
            }

            return false;
        }

        private bool IsCorrectNumberOfMonthDays()
        {
            var monthsConfig = new MonthsConfig(_peselFactors.Year);
            return _peselFactors.Day <= monthsConfig[_peselFactors.Month];
        }
    }
}

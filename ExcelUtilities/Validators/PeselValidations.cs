using ExcelUtilities.Exceptions;
using ExcelUtilities.Helpers;

namespace ExcelUtilities.Validators
{
    public class PeselValidations
    {
        private string _pesel;
        private string _cellLocalization;
        private PeselFactors _peselFactors;
        private MonthConfig _monthConfig;

        public PeselValidations(string pesel, string cellLocalization)
        {            
            _pesel = pesel;
            _cellLocalization = cellLocalization;
            ValidatePeselLengthInCell();
            _peselFactors = new PeselMonthConfig(GetPeselNumbersFactors()).GetCorrectPeselFactors();            
            _monthConfig = new MonthConfig(_peselFactors.Year);
            ValidateMonthLenght();
        }

        public PeselFactors GetPeselFactors()
            => _peselFactors;

        public void ValidatePeselLengthInCell()
        {
            if (_pesel.Length != 11)
            {
                throw new InvalidPeselFormat(_pesel, _cellLocalization);
            }
        }

        private PeselFactors GetPeselNumbersFactors()
        {
            return new PeselFactors
            {
                Day = int.Parse(_pesel[4].ToString() + _pesel[5].ToString()),
                Month = int.Parse(_pesel[2].ToString() + _pesel[3].ToString()),
                Year = int.Parse(_pesel[0].ToString() + _pesel[1].ToString()),
                OtherNumbers = GetOtherPeselNumbers()
            };
        }

        private int GetOtherPeselNumbers()
        {
            var otherPeselNumbersInString = string.Empty;
            for (int i = 6; i < 11; i++)
            {
                otherPeselNumbersInString += _pesel[i];
            }
            return int.Parse(otherPeselNumbersInString); 
        }

        private void ValidateMonthLenght()
        {
            if (_peselFactors.Day > _monthConfig[_peselFactors.Month])
            {
                throw new InvalidDaysNumberInMonth(_peselFactors.Day, _peselFactors.Month);
            }
        }
    }
}

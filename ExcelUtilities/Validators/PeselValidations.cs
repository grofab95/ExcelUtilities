using ExcelUtilities.Exceptions;
using ExcelUtilities.Pesel;

namespace ExcelUtilities.Validators
{
    public class PeselValidations
    {
        public static void ValidatePeselLengthInCell(string peselString, string cellLocalization)
        {
            if (peselString.Length != 11)
            {
                throw new InvalidPeselFormat(peselString, cellLocalization);
            }
        }

        public static void ValidateMonthLenghtByYear(PeselFactors peselFactors, string cellLocalization)
        {
            var monthConfig = new MonthConfig(peselFactors.Year);
            if (peselFactors.Day > monthConfig[peselFactors.Month])
            {
                throw new InvalidDaysNumberInMonth(peselFactors.Day, peselFactors.Month, cellLocalization);
            }
        }
    }
}

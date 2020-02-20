using ExcelUtilities.Exceptions;
using PeselUtilities.Helpers;

namespace PeselUtilities
{
    public class PeselValidations
    {
        public static void ValidatePeselLengthInCell(string peselString, string cellLocalization)
        {
            if (peselString.Length != 11 || !IsNumber(peselString))
            {
                throw new InvalidPeselFormat(peselString, cellLocalization);
            }
        }

        public static void ValidateMonthLenghtByYear(PeselFactors peselFactors, string cellLocalization)
        {
            var monthConfig = new MonthsConfig(peselFactors.Year);
            if (peselFactors.Day > monthConfig[peselFactors.Month])
            {
                throw new InvalidDaysNumberInMonth(peselFactors.Day, peselFactors.Month, cellLocalization);
            }
        }

        private static bool IsNumber(string input)
        {
            return long.TryParse(input, out _);
        }
    }
}

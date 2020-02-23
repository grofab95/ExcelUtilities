using ExcelUtilities.Exceptions;
using PeselUtilities.Helpers;

namespace PeselUtilities
{
    public class PeselValidations
    {
        public static void ValidatePeselFormat(string peselString, string cellLocalization)
        {
            if (!IsPeselLengthCorrect(peselString) || !IsNumber(peselString))
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

        public static bool IsPeselLengthCorrect(string peselString)
        {
            return (peselString.Length == 11);
        }        

        public static bool IsNumber(string input)
        {
            return long.TryParse(input, out _);
        }
    }
}

using ExcelUtilities.Enums;
using System;

namespace ExcelUtilities.Helpers
{
    public class PeselMonthTranslator
    {
        public static int GetCorrectMonth(int peselMonth, PeselYearRangesNames peselYearRangesNames)
        {
            var peselMonthStr = peselMonth.ToString();
            switch (peselYearRangesNames)
            {
                case PeselYearRangesNames.YearInRange1800And1899:
                    if (peselMonth >= 81 && peselMonth <= 89)
                    {
                        return int.Parse(peselMonthStr[1].ToString());
                    }
                    else
                    {
                        return int.Parse("1" + peselMonthStr[1].ToString());
                    }
                case PeselYearRangesNames.YearInRange1900And1999:
                    return peselMonth;
                case PeselYearRangesNames.YearInRange2000And2099:
                    if (peselMonth >= 21 && peselMonth <= 29)
                    {
                        return int.Parse(peselMonthStr[1].ToString());
                    }
                    else
                    {
                        return int.Parse("1" + peselMonthStr[1].ToString());
                    }
            }
            throw new Exception("PeselMonthTranslator -> zły enum...");
        }
    }
}

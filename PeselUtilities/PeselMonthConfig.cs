using PeselUtilities.Enums;
using System;

namespace PeselUtilities
{
    public class PeselMonthConfig
    {
        public static int GetCorrectMonth(int peselMonth, PeselYearRangesNames peselYearRangesNames)
        {
            var peselMonthStr = peselMonth.ToString();
            switch (peselYearRangesNames)
            {
                case PeselYearRangesNames.YearInRange1800And1899:
                    return (peselMonth >= 81 && peselMonth <= 89)
                        ? int.Parse(peselMonthStr[1].ToString())
                        : int.Parse("1" + peselMonthStr[1].ToString());                    
                
                case PeselYearRangesNames.YearInRange2000And2099:
                    return (peselMonth >= 21 && peselMonth <= 29)
                        ? int.Parse(peselMonthStr[1].ToString())
                        : int.Parse("1" + peselMonthStr[1].ToString());

                case PeselYearRangesNames.YearInRange1900And1999:
                    return peselMonth;

            }
            throw new Exception("PeselMonthTranslator -> zły enum...");
        }
    }
}

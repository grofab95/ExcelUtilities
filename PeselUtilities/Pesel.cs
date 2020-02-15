using System;

namespace PeselUtilities
{
    public class Pesel
    {
        public string InString { get; set; }
        public long InNumber { get; set; }
        public string CellLocalization { get; set; }
        public PeselFactors PeselFactors { get; set; }
        public DateTime BornDate { get; set; }

        public Pesel(string inString, string cellLocalization)
        {
            InString = inString;
            InNumber = long.Parse(inString);
            CellLocalization = cellLocalization;
            PeselValidations.ValidatePeselLengthInCell(InString, CellLocalization);
            PeselFactors = new PeselMonthTranslator(ExtractPeselBornDate()).GetCorrectPeselFactors();
            PeselValidations.ValidateMonthLenghtByYear(PeselFactors, CellLocalization);
            BornDate = GetBornDateFromPesel();
        }

        private PeselFactors ExtractPeselBornDate()
        {
            return new PeselFactors
            {
                Day = int.Parse(InString[4].ToString() + InString[5].ToString()),
                Month = int.Parse(InString[2].ToString() + InString[3].ToString()),
                Year = int.Parse(InString[0].ToString() + InString[1].ToString()),
                OtherNumbers = ExtractOtherPeselNumbers()
            };
        }

        private int ExtractOtherPeselNumbers()
        {
            var otherPeselNumbersInString = string.Empty;
            for (int i = 6; i < 11; i++)
            {
                otherPeselNumbersInString += InString[i];
            }
            return int.Parse(otherPeselNumbersInString);
        }

        private DateTime GetBornDateFromPesel()     
            => new DateTime(PeselFactors.Year, PeselFactors.Month, PeselFactors.Day);
        
    }
}

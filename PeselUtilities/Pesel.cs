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
            CellLocalization = cellLocalization;
            PeselValidations.ValidatePeselFormat(InString, CellLocalization);
            PeselFactors = 
                new PeselMonthTranslator(
                    PeselNumberTranslator.ExtractPeselFactors(InString), Enums.ReturnTypeWhenStWrong.Exception, cellLocalization)
                        .GetCorrectPeselFactors();
            PeselValidations.ValidateMonthLenghtByYear(PeselFactors, CellLocalization);
            BornDate = GetBornDateFromPesel();
            InNumber = long.Parse(inString);
        }

        private DateTime GetBornDateFromPesel()     
            => new DateTime(PeselFactors.Year, PeselFactors.Month, PeselFactors.Day);        
    }
}

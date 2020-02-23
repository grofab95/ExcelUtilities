using ParsingUtilities;
using System;
using System.Globalization;

namespace PeselUtilities
{
    public class PeselNumberTranslator
    {
        public static PeselFactors ExtractPeselFactors(string peselString)
        {
            return new PeselFactors
            {
                Day = int.Parse(peselString[4].ToString() + peselString[5].ToString()),
                Month = int.Parse(peselString[2].ToString() + peselString[3].ToString()),
                Year = int.Parse(peselString[0].ToString() + peselString[1].ToString()),
                OtherElements = ExtractOtherPeselElements(peselString)
            };
        }

        public static string ExtractOtherPeselElements(string peselString)
        {
            var otherPeselNumbersInString = string.Empty;
            for (int i = 6; i < 11; i++)
            {
                otherPeselNumbersInString += peselString[i];
            }
            return otherPeselNumbersInString;
        }   
    }
}

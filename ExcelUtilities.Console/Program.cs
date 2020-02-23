using ExcelUtilities.Spreadsheet;
using PeselUtilities;
using System;
using System.Text;

namespace ExcelUtilities.Console
{
    class Program
    {
        static string BuildSummary(Pesel pesel)
        {
            var summary = new StringBuilder();
            summary
                .AppendLine($"PESEL: {pesel.InString} w {pesel.CellLocalization}")
                .AppendLine($"DZIEŃ: {pesel.PeselFactors.Day}")
                .AppendLine($"MIESIĄC: {pesel.PeselFactors.Month}")
                .AppendLine($"ROK: {pesel.PeselFactors.Year}")
                .AppendLine($"DATA URODZENIA: {pesel.BornDate}");
            return summary.ToString();
        }

        static void PrintSummary(Pesel pesel)
            => System.Console.WriteLine(BuildSummary(pesel));

        static void Main()
        {
            try
            {
                System.Console.WriteLine(PeselNumberTranslator.ExtractOtherPeselNumbers("95072636696"));
                System.Console.WriteLine("36696".Length);
                System.Console.ReadKey();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.ReadKey();
            }
        }
    }
}

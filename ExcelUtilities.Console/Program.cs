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
                //var nrPesel = 14201206696.ToString();
                //var pesel = new Pesel(nrPesel, "D1");
                //PrintSummary(pesel);
                //System.Console.ReadKey();
                var excelfileFactors = new ExcelFileFactors
                {
                    ExcelPath = "C:\\Users\\Fabian\\Desktop",
                    ExcelName = "test"
                };

                //using (var excel = new Excel(excelfileFactors))
                //{
                //    System.Console.WriteLine(excel.ReadCell("C1"));
                //}
                System.Console.WriteLine(ExcelCell.TranslateFromXY(3,2));
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

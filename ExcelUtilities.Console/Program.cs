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
                var excelfileFactors = new ExcelFileFactors
                {
                    ExcelPath = "C:\\Users\\Fabian\\Desktop",
                    ExcelName = "test"
                };

                var cellLoc = new CellFactors
                {
                    X = 2,
                    Y = 3,
                };
                var cellLoc2 = new CellFactors
                {
                    X = 10,
                    Y = 3,
                };

                using (var excel = new Excel(excelfileFactors))
                {
                    excel.UpdateCell(cellLoc, "WWW");
                    excel.UpdateCell(cellLoc2, "RRR");
                    excel.Save();
                }
                System.Console.WriteLine();
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

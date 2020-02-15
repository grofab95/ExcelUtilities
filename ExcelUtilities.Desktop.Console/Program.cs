using ExcelUtilities.Validators;
using System;
using System.Text;

namespace ExcelUtilities.Desktop.Console
{
    class Program
    {
        static void Main()
        {
            try
            {
                var pesel1800 = "95123216696";

                var pesel1900 = "95022926696";

                var pesel2000 = "916222936696";

                var pesel = new PeselValidations(pesel2000, "A1").GetPeselFactors();

                var report = new StringBuilder();
                report
                    .AppendLine($"Data urodzenia: {pesel.Day}.{pesel.Month}.{pesel.Year}r.")
                    .AppendLine($"Other: {pesel.OtherNumbers.ToString()}");
                System.Console.WriteLine(report);
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

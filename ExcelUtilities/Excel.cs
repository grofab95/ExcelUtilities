using ExcelUtilities.Pesel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace ExcelUtilities
{
    public class Excel : IDisposable
    {
        private readonly ExcelFileFactors _excelFile;
        private _Application _excel = new Application();
        private Workbook _workbook;
        private Worksheet _worksheet;

        public Excel(ExcelFileFactors excelFile)
        {
            //var fullPath = excelFile.Path + "\\" + excelFile.FileName;
            var fullPath = $"{excelFile.Path}\\{excelFile.FileName}.xlsx";
            _excelFile = excelFile;
            _workbook = _excel.Workbooks.Open(fullPath);
            _worksheet = _workbook.Worksheets[1];
        }
        
        public string ReadCell(string cellLocString)
        {
            var cellLoc = ExcelCell.Translate(cellLocString);
            return ReadCell(cellLoc.X, cellLoc.Y);
        }

        public string ReadCell(int x, int y)
        {
            return _worksheet.Cells[x, y].Value2 != null
                ? _worksheet.Cells[x, y].Value2.ToString()
                : String.Empty;
        }

        public Dictionary<int, Pesel> GetPesele(string firstCell)
        {
            var cellLoc = ExcelCell.Translate(firstCell);
            var pesele = new Dictionary<int, PeselToBirthDate>();
            var index = 1; 
            var x = cellLoc.X;
            _=new PeselToBirthDate(ReadCell(x, cellLoc.Y));
            //while (ReadCell(x, cellLoc.Y) != String.Empty &&
            //    !Validators.IsPesel(ReadCell(x, cellLoc.Y)))
            //{
            //    pesele.Add(index, new PeselToBirthDate(ReadCell(x, cellLoc.Y)));                
            //    index++;
            //    x++;
            //}
            int yyy = x;
            return pesele;
        }

        public void Dispose() => _workbook.Close();
    }
}

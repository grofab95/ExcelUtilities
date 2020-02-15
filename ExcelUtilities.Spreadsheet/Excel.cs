using Microsoft.Office.Interop.Excel;
using PeselUtilities;
using System;
using System.Collections.Generic;

namespace ExcelUtilities.Spreadsheet
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

        public Dictionary<int, Pesel> GetPesele(string firstCell, Pesel pesel)
        {
            var cellLoc = ExcelCell.Translate(firstCell);
            var pesele = new Dictionary<int, Pesel>();
            var index = 1; 
            var x = cellLoc.X;
            while (ReadCell(x, cellLoc.Y) != String.Empty)
            {
                var qqq = new Pesel(ReadCell(x, cellLoc.Y), "Z0");
                pesele.Add(index, new Pesel(ReadCell(x, cellLoc.Y), "Z0"));                
                index++;
                x++;
            }
            int yyy = x;
            return pesele;
        }

        public void Dispose() => _workbook.Close();
    }
}

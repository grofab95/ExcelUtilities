using ExcelUtilities.Helpers;
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
            var fullPath = excelFile.Path + "\\" + excelFile.FileName;
            _excelFile = excelFile;
            _workbook = _excel.Workbooks.Open(fullPath);
            _worksheet = _workbook.Worksheets[1];
        }
        
        public string ReadCell(string cellLocString)
        {
            var cellLoc = ExcelCell.Translate(cellLocString);
            return _worksheet.Cells[cellLoc.X, cellLoc.Y].Value2 != null
                ? _worksheet.Cells[cellLoc.X, cellLoc.Y].Value2.ToString() 
                : String.Empty;
        }

        public string ReadCell(int x, int y)
        {
            return _worksheet.Cells[x, y].Value2 != null
                ? _worksheet.Cells[x, y].Value2.ToString()
                : String.Empty;
        }

        public List<string> ReadColumns(string firstCell)
        {
            var cellLoc = ExcelCell.Translate(firstCell);
            var x = cellLoc.X;
            var y = cellLoc.Y;
            var rows = new List<string>();
            while (ReadCell(x, y) != String.Empty && !CellValidations.IsCellPesel(ReadCell(x, y)))
            {
                rows.Add(ReadCell(x, y));
                x++;
            }
            return rows;
        }

        public void Dispose() => _workbook.Close();
    }
}

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
        private string _fullExcxelPath;

        public Excel(ExcelFileFactors excelFile)
        {
            _fullExcxelPath = $"{excelFile.ExcelPath}\\{excelFile.ExcelName}.{excelFile.ExcelFileExtension}";
            _excelFile = excelFile;
            _workbook = _excel.Workbooks.Open(_fullExcxelPath);
            _worksheet = _workbook.Worksheets[1];
        }
        
        public string ReadCell(string cellLocString)
        {
            var cellLoc = ExcelCell.TranslateFromString(cellLocString);
            return ReadCell(cellLoc.X, cellLoc.Y);
        }

        public string ReadCell(int x, int y)
        {
            return _worksheet.Cells[x, y].Value2 != null
                ? _worksheet.Cells[x, y].Value2.ToString()
                : String.Empty;
        }

        private bool IsPeselCorrect(string pesel)
        {
            var peselFactors = PeselNumberTranslator.ExtractPeselFactors(pesel);
            return
                CellValidations.ValidateCell(pesel) &&
                new PeselSimpleValidations(peselFactors).IsBornDateCorrect();

        }

        public Dictionary<int,T> ReadColumn<T>(string firstColumnCell, string lastColumnCell)
        {
            var columnContents = new Dictionary<int, T>();
            var firstColumnCellLocation = ExcelCell.TranslateFromString(firstColumnCell);
            var actualCellLocation = firstColumnCellLocation;
            var index = 1;
            while (true)
            {
                //columnContents.Add(index, T);
                index++;
            }
            throw new NotImplementedException();
        }

        public Dictionary<int, Pesel> GetPesele(string firstCell, Pesel pesel)
        {
            var cellLoc = ExcelCell.TranslateFromString(firstCell);
            var pesele = new Dictionary<int, Pesel>();
            var index = 1; 
            var x = cellLoc.X;
            while (ReadCell(x, cellLoc.Y) != string.Empty && IsPeselCorrect(ReadCell(x, cellLoc.Y)))
            {
                pesele.Add(index, new Pesel(
                    ReadCell(x, cellLoc.Y), ExcelCell.TranslateFromXY(cellLoc.Y, x)));                
                index++;
                x++;
            }
            return pesele;
        }

        public void UpdateCell(CellFactors cellLocalization, string value)
        {
            var row = _worksheet.Rows.Cells[cellLocalization.X, cellLocalization.Y];
            row.Value = value;
        }

        public void UpdateColumn(string firstColumnCell, Dictionary<int, Pesel> pesele)
        {
            var FirstCellLoc = ExcelCell.TranslateFromString(firstColumnCell);
            var actualX = FirstCellLoc.X;
            var actualY = FirstCellLoc.Y;
            foreach (var pesel in pesele)
            {
                UpdateCell(new CellFactors { X = actualX, Y = actualY }, pesel.Value.BornDate.ToString("dd/MM/yyyy"));
                actualX++;
            }
        }

        public void Save()
        {
            _excel.Application.ActiveWorkbook.Save();
        }

        public void SaveAs()
        {
            _excel.Application.ActiveWorkbook.SaveAs(_excelFile.ExcelPath + "\\" + _excelFile.ExcelName + "DatyUrodzenia", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        public void Dispose() 
        {
            _workbook.Close();
            _excel.Quit();
        }
    }
}

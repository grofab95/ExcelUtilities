using ExcelUtilities.Spreadsheet;
using PeselUtilities;
using System.Collections.Generic;

namespace ExcelUtilities.Desktop
{
    public class MainWindowFactors
    {
        public Pesel Pesel { get; set; }
        public ExcelFileFactors ExcelFileFactors { get; set; }
        public ColumnFactors ColumnFactors { get; set; }
        public Dictionary<int, Pesel> Pesele { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExcelUtilities.Desktop
{
    public partial class MainWindow : Form
    {
        private ExcelFileFactors _excelFile;
        private List<string> _pesele;

        public MainWindow()
        {
            InitializeComponent();
            ComponentReset();
            GB_CellLocation.Enabled = false;
            TB_FilePath.Text = $"C:\\Users\\Fabian\\Desktop";
            TB_FileName.Text = "test.xlsx";
        }

        private void ComponentReset()
        {
            Label_Cell.Text = String.Empty;
            Label_FileName.Text = String.Empty;
            Label_FirstCell.Text = String.Empty;
            Label_PeselAmount.Text = String.Empty;
            Label_Localization.Text = String.Empty;
            Label_FirstPesel.Text = String.Empty;
            Label_PeselAmount.Text = String.Empty;
            Label_PESELE.Text = String.Empty;
            Label_Daty.Text = String.Empty;
        }

        private void UpdateSummary(ExcelFileFactors excelFile)
        {
            Label_Localization.Text = excelFile.Path;
            Label_FileName.Text = excelFile.FileName;
        }

        private void UpdateSummary(ColumnFactors columnFactors)
        {
            Label_FirstCell.Text =  columnFactors.FirstPESELCell.ToUpper();
            Label_FirstPesel.Text = columnFactors.FirstPESEL.ToString();
        }

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            try
            { 
                _excelFile =  new ExcelFileFactors
                {
                    Path = TB_FilePath.Text,
                    FileName = TB_FileName.Text
                };                        
                UpdateSummary(_excelFile);
                GB_Excel.Enabled = false;
                GB_CellLocation.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }
        }
              
        private void Button_SearchCell_Click(object sender, EventArgs e)
        {
            try
            {                
                using (var _excel = new Excel(_excelFile))
                {
                    Validators.ValidateCell(_excel.ReadCell(TB_Cell.Text), TB_Cell.Text);
                    var columnFactors = new ColumnFactors()
                    {
                        FirstPESEL = long.Parse(_excel.ReadCell(TB_Cell.Text)),
                        FirstPESELCell = TB_Cell.Text
                    };
                    UpdateSummary(columnFactors);
                    _pesele = _excel.ReadColumns(TB_Cell.Text);
                    Label_PeselAmount.Text = _pesele.Count().ToString();
                    PrintPESELE();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }
        }

        private void PrintPESELE()
        {
            var x = 1;
            var text = String.Empty;
            foreach (var item in _pesele)
            {
                if (x < 10)
                {
                    text += "  " + x + ". -> " + item + Environment.NewLine;
                } 
                else
                {
                    text += x + ". -> " + item + Environment.NewLine;
                }
                x++;
            }
            Label_PESELE.Text = text;
        }

        private List<DateTime> CreateBirthdatesListFromPesele()
        {
            var birtDates = new List<DateTime>();            
            foreach (var pesel in _pesele)
            {
                birtDates.Add(new PeselToBirthDate(long.Parse(pesel)).GetBirthDate());
            }
            return birtDates;
        }

        private void PrintBirthDates()
        {
            var x = 1;
            var text = String.Empty;
            foreach (var item in CreateBirthdatesListFromPesele())
            {
                if (x < 10)
                {
                    text += "  " + x + ". -> " + item.Date + Environment.NewLine;
                }
                else
                {
                    text += x + ". -> " + item.Date + Environment.NewLine;
                }
                x++;
            }
            Label_Daty.Text = text;
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            try
            {
                PrintBirthDates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }

        }
    }
}

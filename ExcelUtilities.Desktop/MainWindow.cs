using ExcelUtilities.Spreadsheet;
using PeselUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExcelUtilities.Desktop
{
    public partial class MainWindow : Form
    {
        private ExcelFileFactors _excelFile;
        private Dictionary<int, Pesel> _pesele;

        public MainWindow()
        {
            InitializeComponent();
            ComponentReset();
            WindowComponentConfig();
        }

        private void WindowComponentConfig()
        {
            GB_CellLocation.Enabled = false;
            TB_FilePath.Text = $"C:\\Users\\Fabian\\Desktop";
            TB_FileName.Text = "test";
            GB_Pesele.Visible = false;
            GB_FileSummary.Visible = false;
            Button_Show.Enabled = false;
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
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
        }

        private void UpdateSummary(ExcelFileFactors excelFile)
        {
            Label_Localization.Text = excelFile.Path;
            Label_FileName.Text = excelFile.FileName;
        }

        private void UpdateSummary(ColumnFactors columnFactors)
        {
            Label_FirstCell.Text = columnFactors.FirstPeselCell.ToUpper();
            Label_FirstPesel.Text = columnFactors.FirstPesel.ToString();
            Label_PeselAmount.Text = columnFactors.PeselAmount.ToString();
        }

        private void PrintPesele()
        {
            var summary = string.Empty;
            foreach (var pesel in _pesele)
            {
                if (pesel.Key < 10)
                {
                    summary += 
                        $"  {pesel.Key}. ->  {pesel.Value.InString} ->  {pesel.Value.BornDate}{Environment.NewLine}";
                }
                else
                {
                    summary += 
                        $"{pesel.Key}. ->  {pesel.Value.InString} ->  {pesel.Value.BornDate}{Environment.NewLine}";
                }
            }
            Label_PESELE.Text = summary;
        }

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {            
            try
            {
                //Validators.IsInputEmpty(TB_FilePath.Text);
                //Validators.IsInputEmpty(TB_FileName.Text);
                _excelFile = new ExcelFileFactors
                {
                    Path = TB_FilePath.Text,
                    FileName = TB_FileName.Text
                };
                using (var _excel = new Excel(_excelFile)) { }
                UpdateSummary(_excelFile);
                GB_Excel.Enabled = false;
                GB_CellLocation.Enabled = true;
                GB_FileSummary.Visible = true;
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
                //Validators.IsInputEmpty(TB_FirstCell.Text);
                using (var _excel = new Excel(_excelFile))
                {
                    var pesel = new Pesel(_excel.ReadCell(TB_FirstCell.Text), TB_FirstCell.Text);
                    _pesele = _excel.GetPesele(TB_FirstCell.Text, pesel);
                    var columnFactors = new ColumnFactors()
                    {
                        FirstPesel = _pesele.Single(x => x.Key == 1).Value.InNumber,
                        FirstPeselCell = TB_FirstCell.Text,
                        PeselAmount = _pesele.Count()
                    };
                    UpdateSummary(columnFactors);
                    Button_Show.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            try
            {
                //PrintBirthDates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }

        }

        private void Button_Show_Click(object sender, EventArgs e)
        {
            try
            {
                GB_Pesele.Visible = true;
                PrintPesele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }
        }
    }
}

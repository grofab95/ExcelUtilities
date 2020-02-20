using ExcelUtilities.Spreadsheet;
using ExcelUtilities.Spreadsheet.Enums;
using ExcelUtilities.Validators;
using PeselUtilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExcelUtilities.Desktop
{
    public partial class MainWindow : Form
    {
        private MainWindowFactors MainWindowFactors = new MainWindowFactors();

        public MainWindow()
        {
            InitializeComponent();
            ComponentReset();
            WindowComponentConfig();
            FillExcelFileExtensioncomboBox();
            MainWindowFactors.ColumnFactors = new ColumnFactors();           
        }

        private void WindowComponentConfig()
        {
            GB_CellLocation.Enabled = false;
            TB_ExcelPath.Text = $"C:\\Users\\Fabian\\Desktop";
            TB_ExcelName.Text = "test";
            GB_Pesele.Visible = false;
            GB_FileSummary.Visible = false;
            BUTTON_ShowPesele.Enabled = false;
            BUTTON_WriteBornDatesToExcel.Visible = false;
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }

        private void ComponentReset()
        {
            Label_Cell.Text = String.Empty;
            LABEL_ExcelName.Text = String.Empty;
            LABEL_FirstCell.Text = String.Empty;
            LABEL_PeselAmount.Text = String.Empty;
            LABEL_Localization.Text = String.Empty;
            LABEL_FirstPesel.Text = String.Empty;
            LABEL_PeselAmount.Text = String.Empty;
            LABEL_Pesele.Text = String.Empty;
        }

        private void FillExcelFileExtensioncomboBox()
        {
            CB_excelFileExtensions.DataSource = Enum.GetValues(typeof(ExcelFileExtension));

        }

        private void UpdateSummary()
        {
            LABEL_Localization.Text = MainWindowFactors.ExcelFileFactors.ExcelPath;
            LABEL_ExcelName.Text = MainWindowFactors.ExcelFileFactors.ExcelName + "." + 
                MainWindowFactors.ExcelFileFactors.ExcelFileExtension;
            if (MainWindowFactors.Pesel != null)
            {
                LABEL_FirstPesel.Text = MainWindowFactors.Pesel.InString;
                LABEL_FirstCell.Text = MainWindowFactors.Pesel.CellLocalization.ToUpper();
                LABEL_PeselAmount.Text = MainWindowFactors.ColumnFactors.PeselAmount.ToString();
            }            
        }

        private void PrintPesele()
        {
            var summary = string.Empty;
            foreach (var pesel in MainWindowFactors.Pesele)
            {
                if (pesel.Key < 10)
                {
                    summary += 
                        $"[{pesel.Value.CellLocalization.ToUpper()}] -> {pesel.Value.InString} ->  {pesel.Value.BornDate.ToString("dd/MM/yyyy")}{Environment.NewLine}";
                }
                else
                {
                    summary += 
                        $"[{pesel.Value.CellLocalization.ToUpper()}] -> {pesel.Value.InString} ->  {pesel.Value.BornDate.ToString("dd/MM/yyyy")}{Environment.NewLine}";
                }
            }
            LABEL_Pesele.Text = summary;
        }

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {            
            try
            {
                UserInputValidations.EmptyInput(TB_ExcelPath.Text);
                UserInputValidations.EmptyInput(TB_ExcelName.Text);
                MainWindowFactors.ExcelFileFactors = new ExcelFileFactors
                {
                    ExcelPath = TB_ExcelPath.Text,
                    ExcelName = TB_ExcelName.Text,
                    ExcelFileExtension = CB_excelFileExtensions.SelectedItem.ToString()
            };
                using (var _excel = new Excel(MainWindowFactors.ExcelFileFactors)) { }
                UpdateSummary();
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
                UserInputValidations.EmptyInput(TB_FirstCell.Text);
                using (var _excel = new Excel(MainWindowFactors.ExcelFileFactors))
                {
                    SpreadsheetValidations.EmptyCell(_excel.ReadCell(TB_FirstCell.Text), TB_FirstCell.Text);
                    MainWindowFactors.Pesel = new Pesel(_excel.ReadCell(TB_FirstCell.Text), TB_FirstCell.Text);
                    MainWindowFactors.Pesele = _excel.GetPesele(TB_FirstCell.Text, MainWindowFactors.Pesel);
                    MainWindowFactors.ColumnFactors = new ColumnFactors()
                    {
                        FirstPesel = MainWindowFactors.Pesele.Single(x => x.Key == 1).Value.InNumber,
                        FirstPeselCell = TB_FirstCell.Text,
                        PeselAmount = MainWindowFactors.Pesele.Count()
                    };
                    UpdateSummary();
                    BUTTON_ShowPesele.Enabled = true;
                }
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
                BUTTON_WriteBornDatesToExcel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }
        }

        private void BUTTON_WriteBornDatesToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _excel = new Excel(MainWindowFactors.ExcelFileFactors))
                {
                    _excel.UpdateColumn(MainWindowFactors.ColumnFactors.FirstPeselCell, MainWindowFactors.Pesele);
                    _excel.SaveAs();
                    ShowInfoBox();
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uwaga!");
            }
        }

        private void ShowInfoBox()
        {
            var infoMessage = $"Pomyślnie zaktualizowano wierszy: {MainWindowFactors.Pesele.Count()}.";
            MessageBox.Show(infoMessage, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

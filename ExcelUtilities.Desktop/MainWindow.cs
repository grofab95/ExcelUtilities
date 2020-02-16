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
        private MainWindowFactors MainWindowFactors = new MainWindowFactors();

        public MainWindow()
        {
            InitializeComponent();
            ComponentReset();
            WindowComponentConfig();
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

        private void UpdateSummary()
        {
            LABEL_Localization.Text = MainWindowFactors.ExcelFileFactors.ExcelPath;
            LABEL_ExcelName.Text = MainWindowFactors.ExcelFileFactors.ExcelName;
            LABEL_FirstCell.Text = MainWindowFactors.ColumnFactors.FirstPeselString;
            LABEL_PeselAmount.Text = MainWindowFactors.ColumnFactors.PeselAmount.ToString();
        }

        private void PrintPesele()
        {
            var summary = string.Empty;
            foreach (var pesel in MainWindowFactors.Pesele)
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
            LABEL_Pesele.Text = summary;
        }

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {            
            try
            {
                UserInputValidations.IsInputEmpty(TB_ExcelPath.Text);
                UserInputValidations.IsInputEmpty(TB_ExcelName.Text);
                MainWindowFactors.ExcelFileFactors = new ExcelFileFactors
                {
                    ExcelPath = TB_ExcelPath.Text,
                    ExcelName = TB_ExcelName.Text
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
                UserInputValidations.IsInputEmpty(TB_FirstCell.Text);
                using (var _excel = new Excel(MainWindowFactors.ExcelFileFactors))
                {
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

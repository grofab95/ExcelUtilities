namespace ExcelUtilities.Desktop
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Title = new System.Windows.Forms.Label();
            this.BUTTON_OpenExcel = new System.Windows.Forms.Button();
            this.Label_Path = new System.Windows.Forms.Label();
            this.Label_NameFile = new System.Windows.Forms.Label();
            this.TB_ExcelPath = new System.Windows.Forms.TextBox();
            this.TB_ExcelName = new System.Windows.Forms.TextBox();
            this.GB_Excel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_CellLocation = new System.Windows.Forms.GroupBox();
            this.BUTTON_SearchCell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Cell = new System.Windows.Forms.Label();
            this.TB_FirstCell = new System.Windows.Forms.TextBox();
            this.GB_FileSummary = new System.Windows.Forms.GroupBox();
            this.BUTTON_ShowPesele = new System.Windows.Forms.Button();
            this.LABEL_FirstPesel = new System.Windows.Forms.Label();
            this.FirstPESEL = new System.Windows.Forms.Label();
            this.LABEL_Localization = new System.Windows.Forms.Label();
            this.Localization = new System.Windows.Forms.Label();
            this.LABEL_FirstCell = new System.Windows.Forms.Label();
            this.LABEL_PeselAmount = new System.Windows.Forms.Label();
            this.LABEL_ExcelName = new System.Windows.Forms.Label();
            this.PeselAmount = new System.Windows.Forms.Label();
            this.FirstCell = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.LABEL_Pesele = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_Pesele = new System.Windows.Forms.GroupBox();
            this.GB_Excel.SuspendLayout();
            this.GB_CellLocation.SuspendLayout();
            this.GB_FileSummary.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GB_Pesele.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Title.Location = new System.Drawing.Point(8, 21);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(413, 29);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Zamiana peselu na datę urodzenia";
            // 
            // BUTTON_OpenExcel
            // 
            this.BUTTON_OpenExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUTTON_OpenExcel.Location = new System.Drawing.Point(258, 106);
            this.BUTTON_OpenExcel.Name = "BUTTON_OpenExcel";
            this.BUTTON_OpenExcel.Size = new System.Drawing.Size(130, 28);
            this.BUTTON_OpenExcel.TabIndex = 1;
            this.BUTTON_OpenExcel.Text = "Otwórz arkusz";
            this.BUTTON_OpenExcel.UseVisualStyleBackColor = true;
            this.BUTTON_OpenExcel.Click += new System.EventHandler(this.Button_OpenFile_Click);
            // 
            // Label_Path
            // 
            this.Label_Path.AutoSize = true;
            this.Label_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Path.Location = new System.Drawing.Point(6, 35);
            this.Label_Path.Name = "Label_Path";
            this.Label_Path.Size = new System.Drawing.Size(129, 20);
            this.Label_Path.TabIndex = 2;
            this.Label_Path.Text = "Ścieżka arkusza:";
            // 
            // Label_NameFile
            // 
            this.Label_NameFile.AutoSize = true;
            this.Label_NameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_NameFile.Location = new System.Drawing.Point(14, 65);
            this.Label_NameFile.Name = "Label_NameFile";
            this.Label_NameFile.Size = new System.Drawing.Size(121, 20);
            this.Label_NameFile.TabIndex = 3;
            this.Label_NameFile.Text = "Nazwa arkusza:";
            // 
            // TB_ExcelPath
            // 
            this.TB_ExcelPath.Location = new System.Drawing.Point(142, 34);
            this.TB_ExcelPath.Name = "TB_ExcelPath";
            this.TB_ExcelPath.Size = new System.Drawing.Size(246, 22);
            this.TB_ExcelPath.TabIndex = 4;
            // 
            // TB_ExcelName
            // 
            this.TB_ExcelName.Location = new System.Drawing.Point(142, 67);
            this.TB_ExcelName.Name = "TB_ExcelName";
            this.TB_ExcelName.Size = new System.Drawing.Size(207, 22);
            this.TB_ExcelName.TabIndex = 5;
            // 
            // GB_Excel
            // 
            this.GB_Excel.Controls.Add(this.label1);
            this.GB_Excel.Controls.Add(this.Label_Path);
            this.GB_Excel.Controls.Add(this.TB_ExcelName);
            this.GB_Excel.Controls.Add(this.BUTTON_OpenExcel);
            this.GB_Excel.Controls.Add(this.TB_ExcelPath);
            this.GB_Excel.Controls.Add(this.Label_NameFile);
            this.GB_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GB_Excel.Location = new System.Drawing.Point(12, 80);
            this.GB_Excel.Name = "GB_Excel";
            this.GB_Excel.Size = new System.Drawing.Size(409, 162);
            this.GB_Excel.TabIndex = 6;
            this.GB_Excel.TabStop = false;
            this.GB_Excel.Text = "1. Wskaż lokalizację i nazwę arkusza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(350, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ".xlsx";
            // 
            // GB_CellLocation
            // 
            this.GB_CellLocation.Controls.Add(this.BUTTON_SearchCell);
            this.GB_CellLocation.Controls.Add(this.label2);
            this.GB_CellLocation.Controls.Add(this.Label_Cell);
            this.GB_CellLocation.Controls.Add(this.TB_FirstCell);
            this.GB_CellLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GB_CellLocation.Location = new System.Drawing.Point(12, 260);
            this.GB_CellLocation.Name = "GB_CellLocation";
            this.GB_CellLocation.Size = new System.Drawing.Size(409, 123);
            this.GB_CellLocation.TabIndex = 7;
            this.GB_CellLocation.TabStop = false;
            this.GB_CellLocation.Text = "2. Wskaż pierwszą komórkę kolumny zawierającej PESEL";
            // 
            // BUTTON_SearchCell
            // 
            this.BUTTON_SearchCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUTTON_SearchCell.Location = new System.Drawing.Point(258, 74);
            this.BUTTON_SearchCell.Name = "BUTTON_SearchCell";
            this.BUTTON_SearchCell.Size = new System.Drawing.Size(130, 28);
            this.BUTTON_SearchCell.TabIndex = 6;
            this.BUTTON_SearchCell.Text = "Szukaj";
            this.BUTTON_SearchCell.UseVisualStyleBackColor = true;
            this.BUTTON_SearchCell.Click += new System.EventHandler(this.Button_SearchCell_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            // 
            // Label_Cell
            // 
            this.Label_Cell.AutoSize = true;
            this.Label_Cell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Cell.Location = new System.Drawing.Point(14, 37);
            this.Label_Cell.Name = "Label_Cell";
            this.Label_Cell.Size = new System.Drawing.Size(76, 20);
            this.Label_Cell.TabIndex = 5;
            this.Label_Cell.Text = "Komórka:";
            // 
            // TB_FirstCell
            // 
            this.TB_FirstCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_FirstCell.Location = new System.Drawing.Point(96, 31);
            this.TB_FirstCell.MaxLength = 4;
            this.TB_FirstCell.Name = "TB_FirstCell";
            this.TB_FirstCell.Size = new System.Drawing.Size(63, 26);
            this.TB_FirstCell.TabIndex = 6;
            // 
            // GB_FileSummary
            // 
            this.GB_FileSummary.Controls.Add(this.BUTTON_ShowPesele);
            this.GB_FileSummary.Controls.Add(this.LABEL_FirstPesel);
            this.GB_FileSummary.Controls.Add(this.FirstPESEL);
            this.GB_FileSummary.Controls.Add(this.LABEL_Localization);
            this.GB_FileSummary.Controls.Add(this.Localization);
            this.GB_FileSummary.Controls.Add(this.LABEL_FirstCell);
            this.GB_FileSummary.Controls.Add(this.LABEL_PeselAmount);
            this.GB_FileSummary.Controls.Add(this.LABEL_ExcelName);
            this.GB_FileSummary.Controls.Add(this.PeselAmount);
            this.GB_FileSummary.Controls.Add(this.FirstCell);
            this.GB_FileSummary.Controls.Add(this.FileName);
            this.GB_FileSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GB_FileSummary.Location = new System.Drawing.Point(12, 389);
            this.GB_FileSummary.Name = "GB_FileSummary";
            this.GB_FileSummary.Size = new System.Drawing.Size(409, 258);
            this.GB_FileSummary.TabIndex = 8;
            this.GB_FileSummary.TabStop = false;
            this.GB_FileSummary.Text = "Właściwości arkusza";
            // 
            // BUTTON_ShowPesele
            // 
            this.BUTTON_ShowPesele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUTTON_ShowPesele.Location = new System.Drawing.Point(258, 204);
            this.BUTTON_ShowPesele.Name = "BUTTON_ShowPesele";
            this.BUTTON_ShowPesele.Size = new System.Drawing.Size(130, 28);
            this.BUTTON_ShowPesele.TabIndex = 8;
            this.BUTTON_ShowPesele.Text = "Pokaż";
            this.BUTTON_ShowPesele.UseVisualStyleBackColor = true;
            this.BUTTON_ShowPesele.Click += new System.EventHandler(this.Button_Show_Click);
            // 
            // LABEL_FirstPesel
            // 
            this.LABEL_FirstPesel.AutoSize = true;
            this.LABEL_FirstPesel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LABEL_FirstPesel.Location = new System.Drawing.Point(171, 136);
            this.LABEL_FirstPesel.Name = "LABEL_FirstPesel";
            this.LABEL_FirstPesel.Size = new System.Drawing.Size(63, 16);
            this.LABEL_FirstPesel.TabIndex = 10;
            this.LABEL_FirstPesel.Text = "firstPesel";
            // 
            // FirstPESEL
            // 
            this.FirstPESEL.AutoSize = true;
            this.FirstPESEL.Location = new System.Drawing.Point(21, 136);
            this.FirstPESEL.Name = "FirstPESEL";
            this.FirstPESEL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstPESEL.Size = new System.Drawing.Size(110, 16);
            this.FirstPESEL.TabIndex = 9;
            this.FirstPESEL.Text = "Pierwszy PESEL:";
            // 
            // LABEL_Localization
            // 
            this.LABEL_Localization.AutoSize = true;
            this.LABEL_Localization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LABEL_Localization.Location = new System.Drawing.Point(106, 34);
            this.LABEL_Localization.Name = "LABEL_Localization";
            this.LABEL_Localization.Size = new System.Drawing.Size(42, 16);
            this.LABEL_Localization.TabIndex = 8;
            this.LABEL_Localization.Text = "name";
            // 
            // Localization
            // 
            this.Localization.AutoSize = true;
            this.Localization.Location = new System.Drawing.Point(21, 34);
            this.Localization.Name = "Localization";
            this.Localization.Size = new System.Drawing.Size(79, 16);
            this.Localization.TabIndex = 7;
            this.Localization.Text = "Lokalizacja:";
            // 
            // LABEL_FirstCell
            // 
            this.LABEL_FirstCell.AutoSize = true;
            this.LABEL_FirstCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LABEL_FirstCell.Location = new System.Drawing.Point(171, 105);
            this.LABEL_FirstCell.Name = "LABEL_FirstCell";
            this.LABEL_FirstCell.Size = new System.Drawing.Size(28, 16);
            this.LABEL_FirstCell.TabIndex = 6;
            this.LABEL_FirstCell.Text = "first";
            // 
            // LABEL_PeselAmount
            // 
            this.LABEL_PeselAmount.AutoSize = true;
            this.LABEL_PeselAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LABEL_PeselAmount.Location = new System.Drawing.Point(171, 168);
            this.LABEL_PeselAmount.Name = "LABEL_PeselAmount";
            this.LABEL_PeselAmount.Size = new System.Drawing.Size(87, 16);
            this.LABEL_PeselAmount.TabIndex = 5;
            this.LABEL_PeselAmount.Text = "peselAmount";
            // 
            // LABEL_ExcelName
            // 
            this.LABEL_ExcelName.AutoSize = true;
            this.LABEL_ExcelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LABEL_ExcelName.Location = new System.Drawing.Point(171, 76);
            this.LABEL_ExcelName.Name = "LABEL_ExcelName";
            this.LABEL_ExcelName.Size = new System.Drawing.Size(42, 16);
            this.LABEL_ExcelName.TabIndex = 3;
            this.LABEL_ExcelName.Text = "name";
            // 
            // PeselAmount
            // 
            this.PeselAmount.AutoSize = true;
            this.PeselAmount.Location = new System.Drawing.Point(21, 168);
            this.PeselAmount.Name = "PeselAmount";
            this.PeselAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PeselAmount.Size = new System.Drawing.Size(136, 16);
            this.PeselAmount.TabIndex = 2;
            this.PeselAmount.Text = "Wykrytych nr. PESEL:";
            // 
            // FirstCell
            // 
            this.FirstCell.AutoSize = true;
            this.FirstCell.Location = new System.Drawing.Point(21, 106);
            this.FirstCell.Name = "FirstCell";
            this.FirstCell.Size = new System.Drawing.Size(121, 16);
            this.FirstCell.TabIndex = 1;
            this.FirstCell.Text = "Pierwsza komórka:";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(21, 76);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(102, 16);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "Nazwa arkusza:";
            // 
            // LABEL_Pesele
            // 
            this.LABEL_Pesele.AutoSize = true;
            this.LABEL_Pesele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LABEL_Pesele.Location = new System.Drawing.Point(13, 18);
            this.LABEL_Pesele.Name = "LABEL_Pesele";
            this.LABEL_Pesele.Size = new System.Drawing.Size(56, 20);
            this.LABEL_Pesele.TabIndex = 9;
            this.LABEL_Pesele.Text = "pesele";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LABEL_Pesele);
            this.panel1.Location = new System.Drawing.Point(7, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 540);
            this.panel1.TabIndex = 12;
            // 
            // GB_Pesele
            // 
            this.GB_Pesele.Controls.Add(this.panel1);
            this.GB_Pesele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GB_Pesele.Location = new System.Drawing.Point(437, 80);
            this.GB_Pesele.Name = "GB_Pesele";
            this.GB_Pesele.Size = new System.Drawing.Size(381, 567);
            this.GB_Pesele.TabIndex = 11;
            this.GB_Pesele.TabStop = false;
            this.GB_Pesele.Text = "Pesele";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(833, 658);
            this.Controls.Add(this.GB_Pesele);
            this.Controls.Add(this.GB_FileSummary);
            this.Controls.Add(this.GB_CellLocation);
            this.Controls.Add(this.GB_Excel);
            this.Controls.Add(this.Label_Title);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatek do Excela";
            this.GB_Excel.ResumeLayout(false);
            this.GB_Excel.PerformLayout();
            this.GB_CellLocation.ResumeLayout(false);
            this.GB_CellLocation.PerformLayout();
            this.GB_FileSummary.ResumeLayout(false);
            this.GB_FileSummary.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GB_Pesele.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Button BUTTON_OpenExcel;
        private System.Windows.Forms.Label Label_Path;
        private System.Windows.Forms.Label Label_NameFile;
        private System.Windows.Forms.TextBox TB_ExcelPath;
        private System.Windows.Forms.TextBox TB_ExcelName;
        private System.Windows.Forms.GroupBox GB_Excel;
        private System.Windows.Forms.GroupBox GB_CellLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Cell;
        private System.Windows.Forms.TextBox TB_FirstCell;
        private System.Windows.Forms.GroupBox GB_FileSummary;
        private System.Windows.Forms.Label LABEL_FirstCell;
        private System.Windows.Forms.Label LABEL_PeselAmount;
        private System.Windows.Forms.Label LABEL_ExcelName;
        private System.Windows.Forms.Label PeselAmount;
        private System.Windows.Forms.Label FirstCell;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label LABEL_Localization;
        private System.Windows.Forms.Label Localization;
        private System.Windows.Forms.Button BUTTON_SearchCell;
        private System.Windows.Forms.Label LABEL_FirstPesel;
        private System.Windows.Forms.Label FirstPESEL;
        private System.Windows.Forms.Label LABEL_Pesele;
        private System.Windows.Forms.Button BUTTON_ShowPesele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GB_Pesele;
        private System.Windows.Forms.Label label1;
    }
}


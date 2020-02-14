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
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.Label_Path = new System.Windows.Forms.Label();
            this.Label_NameFile = new System.Windows.Forms.Label();
            this.TB_FilePath = new System.Windows.Forms.TextBox();
            this.TB_FileName = new System.Windows.Forms.TextBox();
            this.GB_Excel = new System.Windows.Forms.GroupBox();
            this.GB_CellLocation = new System.Windows.Forms.GroupBox();
            this.Button_SearchCell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Cell = new System.Windows.Forms.Label();
            this.TB_FirstCell = new System.Windows.Forms.TextBox();
            this.GB_FileSummary = new System.Windows.Forms.GroupBox();
            this.Label_FirstPesel = new System.Windows.Forms.Label();
            this.FirstPESEL = new System.Windows.Forms.Label();
            this.Label_Localization = new System.Windows.Forms.Label();
            this.Localization = new System.Windows.Forms.Label();
            this.Label_FirstCell = new System.Windows.Forms.Label();
            this.Label_PeselAmount = new System.Windows.Forms.Label();
            this.Label_FileName = new System.Windows.Forms.Label();
            this.PeselAmount = new System.Windows.Forms.Label();
            this.FirstCell = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.Label_PESELE = new System.Windows.Forms.Label();
            this.Button_Show = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_Pesele = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // Button_OpenFile
            // 
            this.Button_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_OpenFile.Location = new System.Drawing.Point(258, 106);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(130, 28);
            this.Button_OpenFile.TabIndex = 1;
            this.Button_OpenFile.Text = "Otwórz arkusz";
            this.Button_OpenFile.UseVisualStyleBackColor = true;
            this.Button_OpenFile.Click += new System.EventHandler(this.Button_OpenFile_Click);
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
            // TB_FilePath
            // 
            this.TB_FilePath.Location = new System.Drawing.Point(142, 34);
            this.TB_FilePath.Name = "TB_FilePath";
            this.TB_FilePath.Size = new System.Drawing.Size(246, 22);
            this.TB_FilePath.TabIndex = 4;
            // 
            // TB_FileName
            // 
            this.TB_FileName.Location = new System.Drawing.Point(142, 67);
            this.TB_FileName.Name = "TB_FileName";
            this.TB_FileName.Size = new System.Drawing.Size(207, 22);
            this.TB_FileName.TabIndex = 5;
            // 
            // GB_Excel
            // 
            this.GB_Excel.Controls.Add(this.label1);
            this.GB_Excel.Controls.Add(this.Label_Path);
            this.GB_Excel.Controls.Add(this.TB_FileName);
            this.GB_Excel.Controls.Add(this.Button_OpenFile);
            this.GB_Excel.Controls.Add(this.TB_FilePath);
            this.GB_Excel.Controls.Add(this.Label_NameFile);
            this.GB_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GB_Excel.Location = new System.Drawing.Point(12, 80);
            this.GB_Excel.Name = "GB_Excel";
            this.GB_Excel.Size = new System.Drawing.Size(409, 162);
            this.GB_Excel.TabIndex = 6;
            this.GB_Excel.TabStop = false;
            this.GB_Excel.Text = "1. Wskaż lokalizację i nazwę arkusza";
            // 
            // GB_CellLocation
            // 
            this.GB_CellLocation.Controls.Add(this.Button_SearchCell);
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
            // Button_SearchCell
            // 
            this.Button_SearchCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_SearchCell.Location = new System.Drawing.Point(258, 74);
            this.Button_SearchCell.Name = "Button_SearchCell";
            this.Button_SearchCell.Size = new System.Drawing.Size(130, 28);
            this.Button_SearchCell.TabIndex = 6;
            this.Button_SearchCell.Text = "Szukaj";
            this.Button_SearchCell.UseVisualStyleBackColor = true;
            this.Button_SearchCell.Click += new System.EventHandler(this.Button_SearchCell_Click);
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
            this.GB_FileSummary.Controls.Add(this.Button_Show);
            this.GB_FileSummary.Controls.Add(this.Label_FirstPesel);
            this.GB_FileSummary.Controls.Add(this.FirstPESEL);
            this.GB_FileSummary.Controls.Add(this.Label_Localization);
            this.GB_FileSummary.Controls.Add(this.Localization);
            this.GB_FileSummary.Controls.Add(this.Label_FirstCell);
            this.GB_FileSummary.Controls.Add(this.Label_PeselAmount);
            this.GB_FileSummary.Controls.Add(this.Label_FileName);
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
            // Label_FirstPesel
            // 
            this.Label_FirstPesel.AutoSize = true;
            this.Label_FirstPesel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label_FirstPesel.Location = new System.Drawing.Point(171, 136);
            this.Label_FirstPesel.Name = "Label_FirstPesel";
            this.Label_FirstPesel.Size = new System.Drawing.Size(63, 16);
            this.Label_FirstPesel.TabIndex = 10;
            this.Label_FirstPesel.Text = "firstPesel";
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
            // Label_Localization
            // 
            this.Label_Localization.AutoSize = true;
            this.Label_Localization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label_Localization.Location = new System.Drawing.Point(106, 34);
            this.Label_Localization.Name = "Label_Localization";
            this.Label_Localization.Size = new System.Drawing.Size(42, 16);
            this.Label_Localization.TabIndex = 8;
            this.Label_Localization.Text = "name";
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
            // Label_FirstCell
            // 
            this.Label_FirstCell.AutoSize = true;
            this.Label_FirstCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label_FirstCell.Location = new System.Drawing.Point(171, 105);
            this.Label_FirstCell.Name = "Label_FirstCell";
            this.Label_FirstCell.Size = new System.Drawing.Size(28, 16);
            this.Label_FirstCell.TabIndex = 6;
            this.Label_FirstCell.Text = "first";
            // 
            // Label_PeselAmount
            // 
            this.Label_PeselAmount.AutoSize = true;
            this.Label_PeselAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label_PeselAmount.Location = new System.Drawing.Point(171, 168);
            this.Label_PeselAmount.Name = "Label_PeselAmount";
            this.Label_PeselAmount.Size = new System.Drawing.Size(87, 16);
            this.Label_PeselAmount.TabIndex = 5;
            this.Label_PeselAmount.Text = "peselAmount";
            // 
            // Label_FileName
            // 
            this.Label_FileName.AutoSize = true;
            this.Label_FileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label_FileName.Location = new System.Drawing.Point(171, 76);
            this.Label_FileName.Name = "Label_FileName";
            this.Label_FileName.Size = new System.Drawing.Size(42, 16);
            this.Label_FileName.TabIndex = 3;
            this.Label_FileName.Text = "name";
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
            // Label_PESELE
            // 
            this.Label_PESELE.AutoSize = true;
            this.Label_PESELE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_PESELE.Location = new System.Drawing.Point(13, 18);
            this.Label_PESELE.Name = "Label_PESELE";
            this.Label_PESELE.Size = new System.Drawing.Size(56, 20);
            this.Label_PESELE.TabIndex = 9;
            this.Label_PESELE.Text = "pesele";
            // 
            // Button_Show
            // 
            this.Button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Show.Location = new System.Drawing.Point(258, 204);
            this.Button_Show.Name = "Button_Show";
            this.Button_Show.Size = new System.Drawing.Size(130, 28);
            this.Button_Show.TabIndex = 8;
            this.Button_Show.Text = "Pokaż";
            this.Button_Show.UseVisualStyleBackColor = true;
            this.Button_Show.Click += new System.EventHandler(this.Button_Show_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_PESELE);
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
        private System.Windows.Forms.Button Button_OpenFile;
        private System.Windows.Forms.Label Label_Path;
        private System.Windows.Forms.Label Label_NameFile;
        private System.Windows.Forms.TextBox TB_FilePath;
        private System.Windows.Forms.TextBox TB_FileName;
        private System.Windows.Forms.GroupBox GB_Excel;
        private System.Windows.Forms.GroupBox GB_CellLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Cell;
        private System.Windows.Forms.TextBox TB_FirstCell;
        private System.Windows.Forms.GroupBox GB_FileSummary;
        private System.Windows.Forms.Label Label_FirstCell;
        private System.Windows.Forms.Label Label_PeselAmount;
        private System.Windows.Forms.Label Label_FileName;
        private System.Windows.Forms.Label PeselAmount;
        private System.Windows.Forms.Label FirstCell;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label Label_Localization;
        private System.Windows.Forms.Label Localization;
        private System.Windows.Forms.Button Button_SearchCell;
        private System.Windows.Forms.Label Label_FirstPesel;
        private System.Windows.Forms.Label FirstPESEL;
        private System.Windows.Forms.Label Label_PESELE;
        private System.Windows.Forms.Button Button_Show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GB_Pesele;
        private System.Windows.Forms.Label label1;
    }
}


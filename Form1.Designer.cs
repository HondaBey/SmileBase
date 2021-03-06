﻿namespace SmileBase
{
    partial class Form1
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
            this.StudenImportCommand = new System.Windows.Forms.Button();
            this.readStudentSheetButton = new System.Windows.Forms.Button();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.StudentTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ImportAccountingButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ImportExcelTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.appointmentsOverviewLabel = new System.Windows.Forms.Label();
            this.appointmentsGridView = new System.Windows.Forms.DataGridView();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceGridView = new System.Windows.Forms.DataGridView();
            this.AccountingTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DebitsLabel = new System.Windows.Forms.Label();
            this.debitsGridView = new System.Windows.Forms.DataGridView();
            this.paymentsLabel = new System.Windows.Forms.Label();
            this.paymentsGridView = new System.Windows.Forms.DataGridView();
            this.InformationsTabPage = new System.Windows.Forms.TabPage();
            this.informationsTextBox = new System.Windows.Forms.TextBox();
            this.ImportAllAccountingsButton = new System.Windows.Forms.Button();
            this.importGeorgeAccountEntriesButton = new System.Windows.Forms.Button();
            this.georgeOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.georgeFilePathTextBox = new System.Windows.Forms.TextBox();
            this.FindGeorgeFileButton = new System.Windows.Forms.Button();
            this.OpenMainFormButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ImportExcelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).BeginInit();
            this.AccountingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debitsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).BeginInit();
            this.InformationsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudenImportCommand
            // 
            this.StudenImportCommand.Location = new System.Drawing.Point(27, 31);
            this.StudenImportCommand.Name = "StudenImportCommand";
            this.StudenImportCommand.Size = new System.Drawing.Size(131, 23);
            this.StudenImportCommand.TabIndex = 0;
            this.StudenImportCommand.Text = "Import Students";
            this.StudenImportCommand.UseVisualStyleBackColor = true;
            this.StudenImportCommand.Click += new System.EventHandler(this.StudenImportCommand_Click);
            // 
            // readStudentSheetButton
            // 
            this.readStudentSheetButton.Location = new System.Drawing.Point(354, 80);
            this.readStudentSheetButton.Name = "readStudentSheetButton";
            this.readStudentSheetButton.Size = new System.Drawing.Size(131, 23);
            this.readStudentSheetButton.TabIndex = 1;
            this.readStudentSheetButton.Text = "Read Studen Sheet";
            this.readStudentSheetButton.UseVisualStyleBackColor = true;
            this.readStudentSheetButton.Click += new System.EventHandler(this.readStudentSheetButton_Click);
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(27, 82);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(324, 21);
            this.studentsComboBox.TabIndex = 3;
            this.studentsComboBox.SelectedIndexChanged += new System.EventHandler(this.studentsComboBox_SelectedIndexChanged);
            // 
            // StudentTextBox
            // 
            this.StudentTextBox.Location = new System.Drawing.Point(57, 110);
            this.StudentTextBox.Multiline = true;
            this.StudentTextBox.Name = "StudentTextBox";
            this.StudentTextBox.ReadOnly = true;
            this.StudentTextBox.Size = new System.Drawing.Size(428, 105);
            this.StudentTextBox.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(185, 31);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(637, 23);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Appointments Overview";
            // 
            // ImportAccountingButton
            // 
            this.ImportAccountingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportAccountingButton.Location = new System.Drawing.Point(870, 865);
            this.ImportAccountingButton.Name = "ImportAccountingButton";
            this.ImportAccountingButton.Size = new System.Drawing.Size(131, 23);
            this.ImportAccountingButton.TabIndex = 9;
            this.ImportAccountingButton.Text = "Import Accounting";
            this.ImportAccountingButton.UseVisualStyleBackColor = true;
            this.ImportAccountingButton.Click += new System.EventHandler(this.ImportAccountingButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ImportExcelTabPage);
            this.tabControl1.Controls.Add(this.AccountingTabPage);
            this.tabControl1.Controls.Add(this.InformationsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(27, 234);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 625);
            this.tabControl1.TabIndex = 10;
            // 
            // ImportExcelTabPage
            // 
            this.ImportExcelTabPage.Controls.Add(this.splitContainer1);
            this.ImportExcelTabPage.Location = new System.Drawing.Point(4, 22);
            this.ImportExcelTabPage.Name = "ImportExcelTabPage";
            this.ImportExcelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImportExcelTabPage.Size = new System.Drawing.Size(966, 599);
            this.ImportExcelTabPage.TabIndex = 0;
            this.ImportExcelTabPage.Text = "Excel Import";
            this.ImportExcelTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.appointmentsOverviewLabel);
            this.splitContainer1.Panel1.Controls.Add(this.appointmentsGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.balanceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.balanceGridView);
            this.splitContainer1.Size = new System.Drawing.Size(960, 593);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 5;
            // 
            // appointmentsOverviewLabel
            // 
            this.appointmentsOverviewLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentsOverviewLabel.Location = new System.Drawing.Point(0, 0);
            this.appointmentsOverviewLabel.Name = "appointmentsOverviewLabel";
            this.appointmentsOverviewLabel.Size = new System.Drawing.Size(960, 13);
            this.appointmentsOverviewLabel.TabIndex = 6;
            this.appointmentsOverviewLabel.Text = "Appointments Overview";
            // 
            // appointmentsGridView
            // 
            this.appointmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appointmentsGridView.Location = new System.Drawing.Point(0, 19);
            this.appointmentsGridView.Name = "appointmentsGridView";
            this.appointmentsGridView.Size = new System.Drawing.Size(960, 277);
            this.appointmentsGridView.TabIndex = 3;
            // 
            // balanceLabel
            // 
            this.balanceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.balanceLabel.Location = new System.Drawing.Point(0, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(960, 17);
            this.balanceLabel.TabIndex = 7;
            this.balanceLabel.Text = "Balances";
            // 
            // balanceGridView
            // 
            this.balanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.balanceGridView.Location = new System.Drawing.Point(0, 20);
            this.balanceGridView.Name = "balanceGridView";
            this.balanceGridView.Size = new System.Drawing.Size(960, 273);
            this.balanceGridView.TabIndex = 4;
            // 
            // AccountingTabPage
            // 
            this.AccountingTabPage.Controls.Add(this.splitContainer2);
            this.AccountingTabPage.Location = new System.Drawing.Point(4, 22);
            this.AccountingTabPage.Name = "AccountingTabPage";
            this.AccountingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountingTabPage.Size = new System.Drawing.Size(966, 599);
            this.AccountingTabPage.TabIndex = 1;
            this.AccountingTabPage.Text = "Accounting";
            this.AccountingTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DebitsLabel);
            this.splitContainer2.Panel1.Controls.Add(this.debitsGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.paymentsLabel);
            this.splitContainer2.Panel2.Controls.Add(this.paymentsGridView);
            this.splitContainer2.Size = new System.Drawing.Size(960, 593);
            this.splitContainer2.SplitterDistance = 305;
            this.splitContainer2.TabIndex = 5;
            // 
            // DebitsLabel
            // 
            this.DebitsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DebitsLabel.Location = new System.Drawing.Point(0, 0);
            this.DebitsLabel.Name = "DebitsLabel";
            this.DebitsLabel.Size = new System.Drawing.Size(960, 13);
            this.DebitsLabel.TabIndex = 7;
            this.DebitsLabel.Text = "Debits";
            // 
            // debitsGridView
            // 
            this.debitsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debitsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debitsGridView.Location = new System.Drawing.Point(0, 19);
            this.debitsGridView.Name = "debitsGridView";
            this.debitsGridView.Size = new System.Drawing.Size(960, 286);
            this.debitsGridView.TabIndex = 5;
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentsLabel.Location = new System.Drawing.Point(0, 0);
            this.paymentsLabel.Name = "paymentsLabel";
            this.paymentsLabel.Size = new System.Drawing.Size(960, 13);
            this.paymentsLabel.TabIndex = 8;
            this.paymentsLabel.Text = "Payments";
            // 
            // paymentsGridView
            // 
            this.paymentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentsGridView.Location = new System.Drawing.Point(0, 19);
            this.paymentsGridView.Name = "paymentsGridView";
            this.paymentsGridView.Size = new System.Drawing.Size(960, 265);
            this.paymentsGridView.TabIndex = 6;
            // 
            // InformationsTabPage
            // 
            this.InformationsTabPage.Controls.Add(this.informationsTextBox);
            this.InformationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.InformationsTabPage.Name = "InformationsTabPage";
            this.InformationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InformationsTabPage.Size = new System.Drawing.Size(966, 599);
            this.InformationsTabPage.TabIndex = 2;
            this.InformationsTabPage.Text = "Informations";
            this.InformationsTabPage.UseVisualStyleBackColor = true;
            // 
            // informationsTextBox
            // 
            this.informationsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationsTextBox.Location = new System.Drawing.Point(3, 3);
            this.informationsTextBox.Multiline = true;
            this.informationsTextBox.Name = "informationsTextBox";
            this.informationsTextBox.Size = new System.Drawing.Size(960, 593);
            this.informationsTextBox.TabIndex = 0;
            // 
            // ImportAllAccountingsButton
            // 
            this.ImportAllAccountingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportAllAccountingsButton.Location = new System.Drawing.Point(718, 865);
            this.ImportAllAccountingsButton.Name = "ImportAllAccountingsButton";
            this.ImportAllAccountingsButton.Size = new System.Drawing.Size(146, 23);
            this.ImportAllAccountingsButton.TabIndex = 11;
            this.ImportAllAccountingsButton.Text = "Import all Accountings";
            this.ImportAllAccountingsButton.UseVisualStyleBackColor = true;
            this.ImportAllAccountingsButton.Click += new System.EventHandler(this.ImportAllAccountingsButton_Click);
            // 
            // importGeorgeAccountEntriesButton
            // 
            this.importGeorgeAccountEntriesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importGeorgeAccountEntriesButton.Location = new System.Drawing.Point(828, 31);
            this.importGeorgeAccountEntriesButton.Name = "importGeorgeAccountEntriesButton";
            this.importGeorgeAccountEntriesButton.Size = new System.Drawing.Size(173, 23);
            this.importGeorgeAccountEntriesButton.TabIndex = 12;
            this.importGeorgeAccountEntriesButton.Text = "Import George Account";
            this.importGeorgeAccountEntriesButton.UseVisualStyleBackColor = true;
            this.importGeorgeAccountEntriesButton.Click += new System.EventHandler(this.importGeorgeAccountEntriesButton_Click);
            // 
            // georgeOpenFileDialog
            // 
            this.georgeOpenFileDialog.FileName = "openFileDialog1";
            this.georgeOpenFileDialog.Filter = "CSV Datei | *.csv";
            this.georgeOpenFileDialog.InitialDirectory = "\\\\disk\\docs\\Smile\\smileDb";
            // 
            // georgeFilePathTextBox
            // 
            this.georgeFilePathTextBox.Location = new System.Drawing.Point(552, 57);
            this.georgeFilePathTextBox.Name = "georgeFilePathTextBox";
            this.georgeFilePathTextBox.Size = new System.Drawing.Size(416, 20);
            this.georgeFilePathTextBox.TabIndex = 13;
            this.georgeFilePathTextBox.Text = "\\\\disk\\docs\\Smile\\smileDb\\AccountImportGeorge.csv";
            this.georgeFilePathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FindGeorgeFileButton
            // 
            this.FindGeorgeFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindGeorgeFileButton.Location = new System.Drawing.Point(969, 55);
            this.FindGeorgeFileButton.Name = "FindGeorgeFileButton";
            this.FindGeorgeFileButton.Size = new System.Drawing.Size(32, 23);
            this.FindGeorgeFileButton.TabIndex = 14;
            this.FindGeorgeFileButton.Text = "...";
            this.FindGeorgeFileButton.UseVisualStyleBackColor = true;
            this.FindGeorgeFileButton.Click += new System.EventHandler(this.FindGeorgeFileButton_Click);
            // 
            // OpenMainFormButton
            // 
            this.OpenMainFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OpenMainFormButton.Location = new System.Drawing.Point(27, 2);
            this.OpenMainFormButton.Name = "OpenMainFormButton";
            this.OpenMainFormButton.Size = new System.Drawing.Size(131, 23);
            this.OpenMainFormButton.TabIndex = 15;
            this.OpenMainFormButton.Text = "Open Main Form";
            this.OpenMainFormButton.UseVisualStyleBackColor = false;
            this.OpenMainFormButton.Click += new System.EventHandler(this.OpenMainFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 911);
            this.Controls.Add(this.OpenMainFormButton);
            this.Controls.Add(this.FindGeorgeFileButton);
            this.Controls.Add(this.georgeFilePathTextBox);
            this.Controls.Add(this.importGeorgeAccountEntriesButton);
            this.Controls.Add(this.ImportAllAccountingsButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ImportAccountingButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.StudentTextBox);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.readStudentSheetButton);
            this.Controls.Add(this.StudenImportCommand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ImportExcelTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).EndInit();
            this.AccountingTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.debitsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).EndInit();
            this.InformationsTabPage.ResumeLayout(false);
            this.InformationsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudenImportCommand;
        private System.Windows.Forms.Button readStudentSheetButton;
        private System.Windows.Forms.ComboBox studentsComboBox;
        private System.Windows.Forms.TextBox StudentTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button ImportAccountingButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ImportExcelTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label appointmentsOverviewLabel;
        private System.Windows.Forms.DataGridView appointmentsGridView;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.DataGridView balanceGridView;
        private System.Windows.Forms.TabPage AccountingTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label DebitsLabel;
        private System.Windows.Forms.DataGridView debitsGridView;
        private System.Windows.Forms.Label paymentsLabel;
        private System.Windows.Forms.DataGridView paymentsGridView;
        private System.Windows.Forms.Button ImportAllAccountingsButton;
        private System.Windows.Forms.TabPage InformationsTabPage;
        private System.Windows.Forms.TextBox informationsTextBox;
        private System.Windows.Forms.Button importGeorgeAccountEntriesButton;
        private System.Windows.Forms.OpenFileDialog georgeOpenFileDialog;
        private System.Windows.Forms.TextBox georgeFilePathTextBox;
        private System.Windows.Forms.Button FindGeorgeFileButton;
        private System.Windows.Forms.Button OpenMainFormButton;
    }
}


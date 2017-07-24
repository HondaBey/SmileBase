using SmileBase.DerivedControls;

namespace SmileBase.Contacts
{
    partial class ContactControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailLable = new System.Windows.Forms.Label();
            this.MobileLabel = new System.Windows.Forms.Label();
            this.MobileTextBox = new SmileBase.DerivedControls.TextBox();
            this.EmailTextBox = new SmileBase.DerivedControls.TextBox();
            this.DateOfBirthDatePicker = new SmileBase.DerivedControls.DatePicker();
            this.LastNameTextBox = new SmileBase.DerivedControls.TextBox();
            this.FirstNameTextBox = new SmileBase.DerivedControls.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDatePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(18, 15);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(18, 41);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailLable
            // 
            this.EmailLable.AutoSize = true;
            this.EmailLable.Location = new System.Drawing.Point(18, 94);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(32, 13);
            this.EmailLable.TabIndex = 5;
            this.EmailLable.Text = "Email";
            // 
            // MobileLabel
            // 
            this.MobileLabel.AutoSize = true;
            this.MobileLabel.Location = new System.Drawing.Point(18, 121);
            this.MobileLabel.Name = "MobileLabel";
            this.MobileLabel.Size = new System.Drawing.Size(38, 13);
            this.MobileLabel.TabIndex = 7;
            this.MobileLabel.Text = "Mobile";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.IsMandatory = false;
            this.MobileTextBox.Location = new System.Drawing.Point(95, 117);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.NullText = "Enter Mobile Phone";
            this.MobileTextBox.Size = new System.Drawing.Size(221, 21);
            this.MobileTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.IsMandatory = false;
            this.EmailTextBox.Location = new System.Drawing.Point(95, 90);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.NullText = "Enter Email Address";
            this.EmailTextBox.Size = new System.Drawing.Size(221, 21);
            this.EmailTextBox.TabIndex = 6;
            // 
            // DayOfBirthDatePicker
            // 
            this.DateOfBirthDatePicker.IsMandatory = false;
            this.DateOfBirthDatePicker.Location = new System.Drawing.Point(95, 63);
            this.DateOfBirthDatePicker.Name = "DayOfBirthDatePicker";
            this.DateOfBirthDatePicker.NullText = "Enter Day of birth";
            this.DateOfBirthDatePicker.Size = new System.Drawing.Size(221, 21);
            this.DateOfBirthDatePicker.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.IsMandatory = true;
            this.LastNameTextBox.Location = new System.Drawing.Point(95, 37);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.NullText = "Enter Lastname";
            this.LastNameTextBox.Size = new System.Drawing.Size(221, 21);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.IsMandatory = true;
            this.FirstNameTextBox.Location = new System.Drawing.Point(95, 11);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.NullText = "Enter Firstname";
            this.FirstNameTextBox.Size = new System.Drawing.Size(221, 21);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.MobileLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.DateOfBirthDatePicker);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(327, 145);
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDatePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.Label MobileLabel;
        public TextBox EmailTextBox;
        public TextBox MobileTextBox;
        public TextBox FirstNameTextBox;
        public TextBox LastNameTextBox;
        public DatePicker DateOfBirthDatePicker;
    }
}
